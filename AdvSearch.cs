namespace Book_Store
{
	
//
//    Filename: AdvSearch.cs
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
    ///    Summary description for AdvSearch.
    /// </summary>

	public partial class AdvSearch : System.Web.UI.Page
	
    { 



//AdvSearch CustomIncludes begin
		protected CCUtility Utility;
		
		//Search form Search variables and controls declarations
		
		// For each Search form hiddens for PK's,List of Values and Actions
		protected string Search_FormAction="Books.aspx?";
		

	
	public AdvSearch()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// AdvSearch CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// AdvSearch Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// AdvSearch Open Event begin
// AdvSearch Open Event end
		//===============================
		
		//===============================
// AdvSearch OpenAnyPage Event begin
// AdvSearch OpenAnyPage Event end
		//===============================
		//
		//===============================
		// AdvSearch PageSecurity begin
		// AdvSearch PageSecurity end
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
		Search_search_button.Click += new System.EventHandler (this.Search_search_Click);
		
		
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
		Search_Show();
		
        }



// AdvSearch Show end

// End of Login form 







void Search_Show() {
	
// Search Open Event begin
// Search Open Event end

	// Search Show begin
	Utility.buildListBox(Search_category_id.Items,"select category_id,name from categories order by 2","category_id","name","All","");


	string s;
	
	s=Utility.GetParam("name");
	Search_name.Text = s;
	
	s=Utility.GetParam("author");
	Search_author.Text = s;
	
	s=Utility.GetParam("category_id");
	
	try {Search_category_id.SelectedIndex=Search_category_id.Items.IndexOf(Search_category_id.Items.FindByValue(s));
	}catch{}
	
	s=Utility.GetParam("pricemin");
	Search_pricemin.Text = s;
	
	s=Utility.GetParam("pricemax");
	Search_pricemax.Text = s;
	
// Search Show Event begin
// Search Show Event end

	// Search Show end
	
// Search Close Event begin
// Search Close Event end
}

void Search_search_Click(Object Src, EventArgs E) {
	string sURL = Search_FormAction + "name="+Search_name.Text+"&"
	 + "author="+Search_author.Text+"&"
	 + "category_id="+Search_category_id.SelectedItem.Value+"&"
	 + "pricemin="+Search_pricemin.Text+"&"
	 + "pricemax="+Search_pricemax.Text+"&"
	;
	// Transit
	sURL += "";
	Response.Redirect(sURL);
}




    }
}