namespace Book_Store
{
	
//
//    Filename: Header.cs
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
    ///    Summary description for Header.
    /// </summary>

	public partial class Header : System.Web.UI.UserControl
	
    
    { 



//Header CustomIncludes begin
		protected CCUtility Utility;
		
		// For each Menu form hiddens for PK's,List of Values and Actions
		protected string Menu_FormAction=".aspx?";
		

	
	public Header()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// Header CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// Header Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// Header Open Event begin
// Header Open Event end
		//===============================
		
		//===============================
// Header OpenAnyPage Event begin
// Header OpenAnyPage Event end
		//===============================
		//
		//===============================
		// Header PageSecurity begin
		// Header PageSecurity end
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
		Menu_Show();
		
        }



// Header Show end

// End of Login form 






	protected void Menu_Show(){
	  
// Menu Open Event begin
// Menu Open Event end

	  // Menu Show begin				
	  
// Menu BeforeShow Event begin
// Menu BeforeShow Event end

	  // Menu Show end
	  
	}



    }
}