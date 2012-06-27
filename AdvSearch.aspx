<%@ Page language="c#" Inherits="Book_Store.AdvSearch" CodeFile="AdvSearch.cs" %>
<%@ Register TagPrefix="CC" TagName="Header" Src="Header.ascx" %><%@ Register TagPrefix="CC" TagName="Footer" Src="Footer.ascx" %><%@Register TagPrefix="CC" TagName="Pager" Src="CCPager.ascx"%>
<html>
  <head>
	<title>Book Store</title>
	<meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie3-2nav3-0">
	<meta name="GENERATOR" content="YesSoftware CodeCharge v.2.0.5 using 'ASP.NET C#.ccp' build 9/27/2001">
	<meta name="CODE_LANGUAGE" Content="C#">
	<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="expires" content="0">
<meta http-equiv="cache-control" content="no-cache">
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1"></head>
  <body style="background-color: #FFFFFF; color: #000000; font-family: Arial, Tahoma, Verdana, Helveticabackground-color: #FFFFFF; color: #000000; font-family: Arial, Tahoma, Verdana, Helvetica">

  <form method="post" runat="server">
<CC:Header id="Header" runat="server"/>
	
<table><tr><td valign="top" >


    <table id="Search_holder" runat="Server" style="width:100%">
	<tr><td style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1" colspan="11"><a name="Search"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="SearchForm_Title" runat="server">Advanced Search</asp:label></font></a></td></tr>
	<tr>
      <td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Title</font></td>
      <td style="background-color: #FFFFFF; border-width: 1">
	<asp:TextBox
	id=Search_name
 Columns=20
	runat="server"/>
	
	  </td></tr><tr><td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Author</font></td>
      <td style="background-color: #FFFFFF; border-width: 1">
	<asp:TextBox
	id=Search_author
 Columns=20 MaxLength=100
	runat="server"/>
	
	  </td></tr><tr><td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Category</font></td>
      <td style="background-color: #FFFFFF; border-width: 1">
	<asp:DropDownList style="font-size: 10pt; color: #000000"
	id=Search_category_id

	DataTextField="name"
	DataValueField="category_id"
	runat="server"/>
	
	  </td></tr><tr><td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Price more then</font></td>
      <td style="background-color: #FFFFFF; border-width: 1">
	<asp:TextBox
	id=Search_pricemin
 Columns=10
	runat="server"/>
	
	  </td></tr><tr><td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Price less then</font></td>
      <td style="background-color: #FFFFFF; border-width: 1">
	<asp:TextBox
	id=Search_pricemax
 Columns=10
	runat="server"/>
	
	  </td></tr><tr>
      <td align="right" colspan="3">
	  <asp:Button
		id=Search_search_button
		Text="Search"
		runat="server"/>
	</td>
    </tr>
	</table>

</td>
    </tr></table>


<CC:Footer id="Footer" runat="server"/>

    </form>
</body>
</html>