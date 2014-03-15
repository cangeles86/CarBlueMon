package com.sanpablo.carblumon.service;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import org.apache.http.HttpResponse;
import org.apache.http.NameValuePair;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.HttpClient;
import org.apache.http.client.entity.UrlEncodedFormEntity;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.message.BasicNameValuePair;

public class WebServices {
	public void SendLocation(double latitude, double longitude)
	{
		 // Create a new HttpClient and Post Header
		HttpClient httpclient = new DefaultHttpClient();
		HttpPost httppost = new HttpPost("http://localhost:4462/LocationManager/SVLocationManager.svc/Location");
         
        try {
            // Add the data
            List<NameValuePair> nameValuePairs = new ArrayList<NameValuePair>();
            nameValuePairs.add(new BasicNameValuePair("latitude", String.valueOf(latitude)));
            nameValuePairs.add(new BasicNameValuePair("longitude", String.valueOf(longitude)));
 
            httppost.setEntity(new UrlEncodedFormEntity(nameValuePairs));
            
            HttpResponse response = httpclient.execute(httppost);
            if (response.getStatusLine() == null) {
				
			}	
        } catch (ClientProtocolException e) {
            //Log.w("ERROR", e.getMessage());
        } catch (IOException e) {
            //Log.w("ERROR", e.getMessage());
        }

	}
	
}
