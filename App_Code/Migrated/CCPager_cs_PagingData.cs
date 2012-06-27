//====================================================================
// This file is generated as part of Web project conversion.
// The extra class 'PagingData' in the code behind file in 'CCPager.cs' is moved to this file.
//====================================================================




namespace Book_Store
 {

	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	public class PagingData 
	{
         
		private string page;
		private bool enabled;
 
		public PagingData(string page, bool enabled){
			this.page = page;
			this.enabled = enabled;
		}
 
		public string Page {
			get {return page;}
		}
 
		public bool Enabled 
		{
			get 
			{
				return enabled;
			}
		}
	}

}