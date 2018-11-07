package EmailUtils;

import com.aliyuncs.DefaultAcsClient;
import com.aliyuncs.IAcsClient;
import com.aliyuncs.dm.model.v20151123.SingleSendMailRequest;
import com.aliyuncs.dm.model.v20151123.SingleSendMailResponse;
import com.aliyuncs.profile.DefaultProfile;
import com.aliyuncs.profile.IClientProfile;

import java.util.Vector;

public class EmailServices {
    public boolean sendEmail(String _url,String _payload)
    {
        System.out.print("yilianjie");
        //建立与远程账号的链接
        IClientProfile profile = DefaultProfile.getProfile("", "",
                "");
        IAcsClient client = new DefaultAcsClient(profile);
        SingleSendMailRequest request = new SingleSendMailRequest();
        //发送账号
        try {
            request.setAccountName("");
            request.setFromAlias("Email Server");
            request.setAddressType(1);
            request.setReplyToAddress(true);
            request.setToAddress(_url);
            request.setSubject("Your Email");
            request.setHtmlBody(_payload);
            SingleSendMailResponse httpResponse = client.getAcsResponse(request);
        }
        catch (Exception e) {
            System.out.println(e.toString());
            return false;
        }
        return true;
    }
    public boolean sendEmailBatch(String[] _url, String _payload)
    {
        boolean success=true;
        for(int i=0;i<_url.length;i++)
        {
            boolean result=sendEmail(_url[i],_payload);
            if (!result)
                success=false;
        }
        return success;
    }
    /*
    public boolean sendEmailBatch(Vector<String> _url, String _payload)
    {
        boolean success=true;
        for(int i=0;i<_url.size();i++)
        {
            boolean result=sendEmail(_url.elementAt(i),_payload);
            if (!result)
                success=false;
        }
        return success;
    }*/
    public boolean validateEmailAddress(String _url)
    {
        String reg="[a-zA-Z0-9_]+@[a-zA-Z0-9]{2,6}(\\.[a-zA-Z0-9]+){1,4}";
        boolean flag=_url.matches(reg);
        return flag;
    }
}
