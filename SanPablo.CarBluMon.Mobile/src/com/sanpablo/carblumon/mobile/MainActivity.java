package com.sanpablo.carblumon.mobile;

import com.sanpablo.carblumon.service.WebServices;


import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;
import android.location.Criteria;
import android.location.Location;
import android.location.LocationManager;


public class MainActivity extends Activity {

	Button currentLocation;	
	TextView message;
	double latitude;
	double longitude;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //Get Objects Values
        currentLocation = (Button)findViewById(R.id.getLocation);
        message = (TextView)findViewById(R.id.message);
        
        
		
        currentLocation.setOnClickListener(new OnClickListener() {			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Location lo = GetLocation();
				WebServices ws = new WebServices();
				ws.SendLocation(1, 1);
				String message1;
				if (lo == null) {
					message1 = "Error";
				}
				else {
					message1 = "Bien";
				}
		        Toast.makeText(getApplicationContext(), message1 , Toast.LENGTH_SHORT).show();
				//WebServices services= new WebServices();
				//services.SendLocation(latitude, longitude);
			}
		});
   }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }
    
    private Location GetLocation()
    {
    	Location lastLocation;
    	
    	LocationManager mlocManager = (LocationManager)getSystemService(LOCATION_SERVICE);
        
        Criteria criteria = new Criteria();
        criteria.setAccuracy( Criteria.ACCURACY_COARSE );
        String provider = mlocManager.getBestProvider( criteria, true );

        if ( provider == null ) {
            //Log.e( TAG, "No location provider found!" );
            lastLocation = null;
        }
        else {
        	lastLocation = mlocManager.getLastKnownLocation(provider);
            latitude = lastLocation.getLatitude();
            longitude = lastLocation.getLongitude();
		}
        
        return lastLocation;
    }
    
}
