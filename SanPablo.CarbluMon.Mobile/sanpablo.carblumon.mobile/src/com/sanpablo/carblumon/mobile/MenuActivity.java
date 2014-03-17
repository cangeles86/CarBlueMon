package com.sanpablo.carblumon.mobile;

import com.sanpablo.carbluemon.services.WCFServices;

import android.content.Intent;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.support.v7.app.ActionBarActivity;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.Toast;

public class MenuActivity extends ActionBarActivity {

	Button btnMedicine;
	Button btnHelpRequest;
	Button btnPhoneDirectory;
	Button btnChangeState;
	Button btnRequestAttention;
	Button btnECG;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_menu);

		if (savedInstanceState == null) {
			getSupportFragmentManager().beginTransaction()
					.add(R.id.container, new PlaceholderFragment()).commit();
		}
		btnMedicine = (Button)findViewById(R.id.btnMedicine);
		btnHelpRequest = (Button)findViewById(R.id.btnHelpRequest);
		btnPhoneDirectory = (Button)findViewById(R.id.btnPhoneDirectory);
		btnChangeState = (Button)findViewById(R.id.btnChangeState);
		btnRequestAttention = (Button)findViewById(R.id.btnRequestAttention);
		btnECG = (Button)findViewById(R.id.btnECG);
		
		btnMedicine.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Intent medicineView = new Intent(getApplicationContext(), MedicineActivity.class);
				startActivity(medicineView);
			}
		});
		
		btnHelpRequest.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				WCFServices client = new WCFServices();
				Boolean result = client.SendHelpRequest(1, 0, 0);				
				
				if (result) {
					Toast message = Toast.makeText(getApplicationContext(), "Enviado", Toast.LENGTH_SHORT);
					message.show();
				} else {
					Toast message = Toast.makeText(getApplicationContext(), "Error", Toast.LENGTH_SHORT);
					message.show();
				}
			}
		});
		
		btnPhoneDirectory.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Intent phoneDirectoryView = new Intent(getApplicationContext(), PhoneDirectoryActivity.class);
				startActivity(phoneDirectoryView);
			}
		});
		
		btnChangeState.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Intent changeStateView = new Intent(getApplicationContext(), ChangeStateActivity.class);
				startActivity(changeStateView);
			}
		});
		
		btnRequestAttention.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Intent requestAttentionView = new Intent(getApplicationContext(), RequestAttentionActivity.class);
				startActivity(requestAttentionView);
			}
		});
	
		btnECG.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Intent ecgView = new Intent(getApplicationContext(), ECKActivity.class);
				startActivity(ecgView);
			}
		});
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {

		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.menu, menu);
		return true;
	}

	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		// Handle action bar item clicks here. The action bar will
		// automatically handle clicks on the Home/Up button, so long
		// as you specify a parent activity in AndroidManifest.xml.
		int id = item.getItemId();
		if (id == R.id.action_settings) {
			return true;
		}
		return super.onOptionsItemSelected(item);
	}

	/**
	 * A placeholder fragment containing a simple view.
	 */
	public static class PlaceholderFragment extends Fragment {

		public PlaceholderFragment() {
		}

		@Override
		public View onCreateView(LayoutInflater inflater, ViewGroup container,
				Bundle savedInstanceState) {
			View rootView = inflater.inflate(R.layout.fragment_menu, container,
					false);
			return rootView;
		}
	}

}
