package com.sanpablo.carbluemon.services;

import java.util.Date;

import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.entity.StringEntity;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.util.EntityUtils;
import org.json.JSONObject;

public class WCFServices {
	public Boolean SendHelpRequest(int user, double latitude, double longitude)
	{
		Boolean result = null;
		String errorMessage = "";
		HttpClient httpClient = new DefaultHttpClient();
		HttpPost post =
			    new HttpPost
			    ("http://servicecarblumon.apphb.com/HelpRequests/HelpRequest.svc/HelpRequests");
		post.setHeader("content-type", "application/json");
				
		try {
			
			
			JSONObject helpRequets = new JSONObject();
			
			helpRequets.put("Latitude", latitude);
			helpRequets.put("Longitude", longitude);			
			helpRequets.put("State", true);
			
			JSONObject userRequest = new JSONObject();
			userRequest.put("Id", user);
			
			helpRequets.put("User",userRequest);
			
			StringEntity entity = new StringEntity(helpRequets.toString());
			post.setEntity(entity);
			
			HttpResponse resp = httpClient.execute(post);
            String respStr = EntityUtils.toString(resp.getEntity());
            result =  true;
		} catch (Exception e) {
			// TODO: handle exception
			errorMessage = e.getMessage();
			result = false;
		}
			
		return result;		
	}
}