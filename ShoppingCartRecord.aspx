<%@ Page language="c#" Inherits="Book_Store.ShoppingCartRecord" CodeFile="ShoppingCartRecord.cs" %>
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
	<input type=hidden id=p_ShoppingCartRecord_order_id runat=server />
	
<table><tr><td valign="top" >

<table  id="ShoppingCartRecord_holder" runat="Server" style="width:100%">
	<tr><td colspan=2 style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="ShoppingCartRecordForm_Title" runat="server">ShoppingCart</asp:label></font><br>
	</td></tr>
	<tr><td colspan="2" style="background-color: #FFFFFF; border-width: 1">
	<asp:Label id=ShoppingCartRecord_ValidationSummary style="background-color: #FFFFFF; border-width: 1" runat="server" Visible="false"></asp:Label>

	<input type="Hidden" id="ShoppingCartRecord_order_id" value="" runat="server">

	<input type="Hidden" id="ShoppingCartRecord_member_id" value="" runat="server">
</td></tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Item</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=ShoppingCartRecord_item_id
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Quantity</font>
	<asp:RequiredFieldValidator id=ShoppingCartRecord_quantity_Validator_Req runat="server" ErrorMessage="The value in field Quantity is required." ControlToValidate="ShoppingCartRecord_quantity" display="None" EnableClientScript="False"></asp:RequiredFieldValidator>
	<asp:CustomValidator  id=ShoppingCartRecord_quantity_Validator_Num OnServerValidate="ValidateNumeric" runat="server" EnableClientScript="False" ErrorMessage="The value in field Quantity is incorrect." ControlToValidate="ShoppingCartRecord_quantity" display="None"></asp:CustomValidator ></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=ShoppingCartRecord_quantity
 Columns=5
	runat="server"/>
&nbsp;</td>
	</tr>

    <tr><td align=right colspan=2 >

	<input type="button"
		id=ShoppingCartRecord_update
		Value="Update"
		runat="server" >
	
	<input type="button"
		id=ShoppingCartRecord_delete
		Value="Delete"
		runat="server" >
	
	<input type="button"
		id=ShoppingCartRecord_cancel
		Value="Cancel"
		runat="server" >
	
    </td></tr>

	</table>

<SCRIPT Language="JavaScript">
if (document.forms["ShoppingCartRecord"])
document.ShoppingCartRecord.onsubmit=delconf;
function delconf() {
if (document.ShoppingCartRecord.FormAction.value == 'delete')
  return confirm('Delete record?');
}
</SCRIPT>
</td>
    </tr></table>


<CC:Footer id="Footer" runat="server"/>

    </form>
</body>
</html>