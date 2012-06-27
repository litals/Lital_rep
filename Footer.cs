namespace Book_Store
{
	
//
//    Filename: Footer.cs
//    Generated with CodeCharge 2.0.5
//    ASP.NET C#.ccp build 03/07/2002
//
//-------------------------------
//

    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.Drawing;
    using System.Web;
    using System.Web.SessionState;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;

    /// <summary>
    ///    Summary description for Footer.
    /// </summary>

	public partial class Footer : System.Web.UI.UserControl
	
    
    { 



//Footer CustomIncludes begin
		protected CCUtility Utility;
		
		// For each Footer form hiddens for PK's,List of Values and Actions
		protected string Footer_FormAction=".aspx?";
		

	
	public Footer()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// Footer CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// Footer Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// Footer Open Event begin
// Footer Open Event end
		//===============================
		
		//===============================
// Footer OpenAnyPage Event begin
// Footer OpenAnyPage Event end
		//===============================
		//
		//===============================
		// Footer PageSecurity begin
		// Footer PageSecurity end
		//===============================

		if (!IsPostBack){
			Page_Show(sender, e);
		}
	}

	protected void Page_Unload(object sender, EventArgs e)
	{
		//
		// CODEGEN: This call is required by the ASP+ Windows Form Designer.
		//
		if(Utility!=null) Utility.DBClose();
	}

	protected void Page_Init(object sender, EventArgs e)
	{
		//
		// CODEGEN: This call is required by the ASP+ Windows Form Designer.
		//
		InitializeComponent();
		
		
	}

        /// <summary>
        ///    Required method for Designer support - do not modify
        ///    the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        }


        protected void Page_Show(object sender, EventArgs e)
        {
		Footer_Show();
		
        }



// Footer Show end

// End of Login form 






	protected void Footer_Show(){
	  
// Footer Open Event begin
// Footer Open Event end

	  // Footer Show begin				
	  
// Footer BeforeShow Event begin
// Footer BeforeShow Event end

	  // Footer Show end
	  
	}



    }
}