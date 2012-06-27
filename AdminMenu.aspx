<%@ Page language="c#" Inherits="Book_Store.AdminMenu" CodeFile="AdminMenu.cs" %>
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


  <table id="Form_holder" runat="Server" style="width:100%">
  <tr><td  style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="FormForm_Title" runat="server">Administration Menu</asp:label></font></td></tr>
  <tr>
  
    <td style="background-color: #FFFFFF; border-width: 1">
    <asp:HyperLink NavigateUrl="MembersGrid.aspx" id=Form_Field1
style="font-size: 10pt; color: #000000" runat="server">Members</asp:HyperLink></td></tr><tr>
    <td style="background-color: #FFFFFF; border-width: 1">
    <asp:HyperLink NavigateUrl="OrdersGrid.aspx" id=Form_Field2
style="font-size: 10pt; color: #000000" runat="server">Orders</asp:HyperLink></td></tr><tr>
    <td style="background-color: #FFFFFF; border-width: 1">
    <asp:HyperLink NavigateUrl="AdminBooks.aspx" id=Form_Field3
style="font-size: 10pt; color: #000000" runat="server">Books</asp:HyperLink></td></tr><tr>
    <td style="background-color: #FFFFFF; border-width: 1">
    <asp:HyperLink NavigateUrl="CategoriesGrid.aspx" id=Form_Field4
style="font-size: 10pt; color: #000000" runat="server">Categories</asp:HyperLink></td></tr><tr>
    <td style="background-color: #FFFFFF; border-width: 1">
    <asp:HyperLink NavigateUrl="EditorialsGrid.aspx" id=Form_Field5
style="font-size: 10pt; color: #000000" runat="server">Editorials</asp:HyperLink></td></tr><tr>
    <td style="background-color: #FFFFFF; border-width: 1">
    <asp:HyperLink NavigateUrl="EditorialCatGrid.aspx" id=Form_Field6
style="font-size: 10pt; color: #000000" runat="server">Editorial Categories</asp:HyperLink></td></tr><tr>
    <td style="background-color: #FFFFFF; border-width: 1">
    <asp:HyperLink NavigateUrl="CardTypesGrid.aspx" id=Form_Field
style="font-size: 10pt; color: #000000" runat="server">Card Types</asp:HyperLink></td>
    </tr>
  </table>

</td>
    </tr></table>


<CC:Footer id="Footer" runat="server"/>

    </form>
</body>
</html>