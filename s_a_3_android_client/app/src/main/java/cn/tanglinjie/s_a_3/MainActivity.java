package cn.tanglinjie.s_a_3;

import android.os.Handler;
import android.os.Message;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import java.nio.Buffer;
import java.util.Vector;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    private EditText address;
    private EditText content;
    private Button sendButton;
    private Button checkAddressButton;

    private String namespace="http://EmailUtils";
    private String method;
    private String url="http://172.30.112.67:8080/services/EmailServer?wsdl";//注意地址不能为localhost
    private Handler handler=new Handler()
    {
        @Override
        public void handleMessage(Message msg) {
            switch(msg.what)
            {
                case 0x001:
                    Toast.makeText(MainActivity.this,"发送成功！",Toast.LENGTH_SHORT).show();
                    break;
                case 0x002:
                    Toast.makeText(MainActivity.this,"发送失败！",Toast.LENGTH_SHORT).show();
                    break;
                case 0x003:
                    Toast.makeText(MainActivity.this,"地址格式正确！",Toast.LENGTH_SHORT).show();
                    break;
                case 0x004:
                    Toast.makeText(MainActivity.this,"地址格式错误！",Toast.LENGTH_SHORT).show();
                    break;
            }
        }
    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        init();
    }
    public void init()
    {
        address=(EditText)findViewById(R.id.address);
        content=(EditText)findViewById(R.id.content);
        sendButton=(Button)findViewById(R.id.send_button);
        checkAddressButton=(Button)findViewById(R.id.check_address);
        sendButton.setOnClickListener(this);
        checkAddressButton.setOnClickListener(this);
    }
    public void sendEmail()
    {
        String sendContent=content.getText().toString();
        sendContent.replace("\n","");
        String addresses=address.getText().toString();
        addresses.replace("\n","");
        String[] sendAddressesArray=addresses.split(";");
        Vector<String> vector=new Vector<>();
        for(int i=0;i<sendAddressesArray.length;i++)
        {
            vector.add(sendAddressesArray[i]);
        }

        SoapObject soapObject=null;
        if (vector.size()==1) {
            method="sendEmail";
            soapObject=new SoapObject(namespace,method);
            soapObject.addProperty("_url",vector.elementAt(0));
            soapObject.addProperty("_payload",sendContent);
        }
        else
        {
            method="sendEmailBatch";
            soapObject=new SoapObject(namespace,method);
            soapObject.addProperty("_url",vector);
            soapObject.addProperty("_payload",sendContent);
        }
        SoapSerializationEnvelope soapSerializationEnvelope=new SoapSerializationEnvelope(SoapSerializationEnvelope.VER11);
        soapSerializationEnvelope.bodyOut=soapObject;
        soapSerializationEnvelope.dotNet=false;
        HttpTransportSE httpTransportSE=new HttpTransportSE(url);
        try {
            httpTransportSE.call("", soapSerializationEnvelope);

            SoapObject result = (SoapObject) soapSerializationEnvelope.bodyIn;
            boolean resultBool=Boolean.parseBoolean(result.getProperty(0).toString());
            if(resultBool)
                handler.sendEmptyMessage(0x001);
            else
                handler.sendEmptyMessage(0x002);
        }
        catch (Exception e)
        {
            System.out.print(e.toString());
            handler.sendEmptyMessage(0x002);
        }
    }
    public void checkAddress() {
        String addresses = address.getText().toString();
        method = "validateEmailAddress";
        SoapObject soapObject = new SoapObject(namespace, method);
        soapObject.addProperty("_url", addresses);

        SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapSerializationEnvelope.VER11);
        envelope.bodyOut = soapObject;
        envelope.dotNet = false;

        HttpTransportSE httpTransportSE = new HttpTransportSE(url);
        try {
            httpTransportSE.call(null, envelope);

            SoapObject result=(SoapObject)envelope.bodyIn;
            boolean correct=Boolean.parseBoolean(result.getProperty(0).toString());
            if(correct)
                handler.sendEmptyMessage(0x003);
            else
                handler.sendEmptyMessage(0x004);
        }
        catch (Exception e)
        {
            System.out.print(e.toString());
            handler.sendEmptyMessage(0x004);
        }
    }
    @Override
    public void onClick(View view) {
        switch (view.getId())
        {
            case R.id.send_button:
                new Thread(){
                    @Override
                    public void run() {
                        sendEmail();
                    }
                }.start();
                break;
            case R.id.check_address:
                new Thread() {
                    @Override
                    public void run() {
                        checkAddress();
                    }
                }.start();
                break;
        }
    }
}
