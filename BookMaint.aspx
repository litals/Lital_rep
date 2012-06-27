<%@ Page language="c#" Inherits="Book_Store.BookMaint" CodeFile="BookMaint.cs" %>
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
	<input type=hidden id=p_Book_item_id runat=server />
	
<table><tr><td valign="top" >

<table  id="Book_holder" runat="Server" style="width:100%">
	<tr><td colspan=2 style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="BookForm_Title" runat="server">Book</asp:label></font><br>
	</td></tr>
	<tr><td colspan="2" style="background-color: #FFFFFF; border-width: 1">
	<asp:Label id=Book_ValidationSummary style="background-color: #FFFFFF; border-width: 1" runat="server" Visible="false"></asp:Label>

	<input type="Hidden" id="Book_item_id" value="" runat="server">
</td></tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Title</font>
	<asp:RequiredFieldValidator id=Book_name_Validator_Req runat="server" ErrorMessage="The value in field Title is required." ControlToValidate="Book_name" display="None" EnableClientScript="False"></asp:RequiredFieldValidator></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Book_name
 Columns=30 MaxLength=100
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Author</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Book_author
 Columns=30 MaxLength=100
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Category</font>
	<asp:RequiredFieldValidator id=Book_category_id_Validator_Req runat="server" ErrorMessage="The value in field Category is required." ControlToValidate="Book_category_id" display="None" EnableClientScript="False"></asp:RequiredFieldValidator>
	<asp:CustomValidator  id=Book_category_id_Validator_Num OnServerValidate="ValidateNumeric" runat="server" EnableClientScript="False" ErrorMessage="The value in field Category is incorrect." ControlToValidate="Book_category_id" display="None"></asp:CustomValidator ></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:DropDownList style="font-size: 10pt; color: #000000"
	id=Book_category_id

	DataTextField="name"
	DataValueField="category_id"
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Price</font>
	<asp:RequiredFieldValidator id=Book_price_Validator_Req runat="server" ErrorMessage="The value in field Price is required." ControlToValidate="Book_price" display="None" EnableClientScript="False"></asp:RequiredFieldValidator>
	<asp:CustomValidator  id=Book_price_Validator_Num OnServerValidate="ValidateNumeric" runat="server" EnableClientScript="False" ErrorMessage="The value in field Price is incorrect." ControlToValidate="Book_price" display="None"></asp:CustomValidator ></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Book_price
 Columns=10
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Product URL</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Book_product_url
 Columns=40 MaxLength=100
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Image URL</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Book_image_url
 Columns=40 MaxLength=100
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Notes</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:TextBox	id=Book_notes
style="font-size: 10pt; color: #000000" TextMode=MultiLine Rows=8 Columns=60 runat="server">
	
	</asp:TextBox>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Recommended</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:CheckBox style="font-size: 10pt; color: #000000" id=Book_is_recommended runat="server"/>
&nbsp;</td>
	</tr>

    <tr><td align=right colspan=2 >

	<input type="button"
		id=Book_insert
		Value="Add"
		runat="server" >
	
	<input type="button"
		id=Book_update
		Value="Update"
		runat="server" >
	
	<input type="button"
		id=Book_delete
		Value="Delete"
		runat="server" >
	
	<input type="button"
		id=Book_cancel
		Value="Cancel"
		runat="server" >
	
    </td></tr>

	</table>

<SCRIPT Language="JavaScript">
if (document.forms["Book"])
document.Book.onsubmit=delconf;
function delconf() {
if (document.Book.FormAction.value == 'delete')
  return confirm('Delete record?');
}
</SCRIPT>
</td>
    </tr></table>


<CC:Footer id="Footer" runat="server"/>

    </form>
</body>
</html>