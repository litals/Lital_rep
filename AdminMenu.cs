namespace Book_Store
{
//
//	
//
//    Filename: AdminMenu.cs
//    Generated with CodeCharge 2.0.5
//    ASP.NET C#.ccp build 03/07/2002
//
//-------------------------------
//
// 
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
    ///    Summary description for AdminMenu.
    /// </summary>

	public partial class AdminMenu : System.Web.UI.Page
	
    { 



//AdminMenu CustomIncludes begin
		protected CCUtility Utility;
		
		// For each Form form hiddens for PK's,List of Values and Actions
		protected string Form_FormAction=".aspx?";
		

	
	public AdminMenu()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// AdminMenu CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// AdminMenu Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// AdminMenu Open Event begin
// AdminMenu Open Event end
		//===============================
		
		//===============================
// AdminMenu OpenAnyPage Event begin
// AdminMenu OpenAnyPage Event end
		//===============================
		//
		//===============================
		// AdminMenu PageSecurity begin
		Utility.CheckSecurity(2);
		// AdminMenu PageSecurity end
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
		Form_Show();
		
        }



// AdminMenu Show end

// End of Login form 






	protected void Form_Show(){
	  
// Form Open Event begin
// Form Open Event end

	  // Form Show begin				
	  
// Form BeforeShow Event begin
// Form BeforeShow Event end

	  // Form Show end
	  
	}



    }
}