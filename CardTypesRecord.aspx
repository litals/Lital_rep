<%@ Page language="c#" Inherits="Book_Store.CardTypesRecord" CodeFile="CardTypesRecord.cs" %>
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
	<input type=hidden id=p_CardTypes_card_type_id runat=server />
	
<table><tr><td valign="top" >

<table  id="CardTypes_holder" runat="Server" style="width:100%">
	<tr><td colspan=2 style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="CardTypesForm_Title" runat="server">Card Type</asp:label></font><br>
	</td></tr>
	<tr><td colspan="2" style="background-color: #FFFFFF; border-width: 1">
	<asp:Label id=CardTypes_ValidationSummary style="background-color: #FFFFFF; border-width: 1" runat="server" Visible="false"></asp:Label>

	<input type="Hidden" id="CardTypes_card_type_id" value="" runat="server">
</td></tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Name</font>
	<asp:RequiredFieldValidator id=CardTypes_name_Validator_Req runat="server" ErrorMessage="The value in field Name is required." ControlToValidate="CardTypes_name" display="None" EnableClientScript="False"></asp:RequiredFieldValidator></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=CardTypes_name
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>

    <tr><td align=right colspan=2 >

	<input type="button"
		id=CardTypes_insert
		Value="Insert"
		runat="server" >
	
	<input type="button"
		id=CardTypes_update
		Value="Update"
		runat="server" >
	
	<input type="button"
		id=CardTypes_delete
		Value="Delete"
		runat="server" >
	
	<input type="button"
		id=CardTypes_cancel
		Value="Cancel"
		runat="server" >
	
    </td></tr>

	</table>


</td>
    </tr></table>


<CC:Footer id="Footer" runat="server"/>

    </form>
</body>
</html>