<%@ Page language="c#" Inherits="Book_Store.MyInfo" CodeFile="MyInfo.cs" %>
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
	<input type=hidden id=p_Form_member_id runat=server />
	
<table><tr><td valign="top" >

<table  id="Form_holder" runat="Server" style="width:100%">
	<tr><td colspan=2 style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="FormForm_Title" runat="server">MyInfo</asp:label></font><br>
	</td></tr>
	<tr><td colspan="2" style="background-color: #FFFFFF; border-width: 1">
	<asp:Label id=Form_ValidationSummary style="background-color: #FFFFFF; border-width: 1" runat="server" Visible="false"></asp:Label>

	<input type="Hidden" id="Form_member_id" value="" runat="server">
</td></tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Login</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Form_member_login
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Password*</font>
	<asp:RequiredFieldValidator id=Form_member_password_Validator_Req runat="server" ErrorMessage="The value in field Password* is required." ControlToValidate="Form_member_password" display="None" EnableClientScript="False"></asp:RequiredFieldValidator></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Form_member_password
 TextMode=Password Columns=20
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">First Name*</font>
	<asp:RequiredFieldValidator id=Form_name_Validator_Req runat="server" ErrorMessage="The value in field First Name* is required." ControlToValidate="Form_name" display="None" EnableClientScript="False"></asp:RequiredFieldValidator></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Form_name
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Last Name*</font>
	<asp:RequiredFieldValidator id=Form_last_name_Validator_Req runat="server" ErrorMessage="The value in field Last Name* is required." ControlToValidate="Form_last_name" display="None" EnableClientScript="False"></asp:RequiredFieldValidator></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Form_last_name
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Email*</font>
	<asp:RequiredFieldValidator id=Form_email_Validator_Req runat="server" ErrorMessage="The value in field Email* is required." ControlToValidate="Form_email" display="None" EnableClientScript="False"></asp:RequiredFieldValidator></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Form_email
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Address</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Form_address
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Phone</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Form_phone
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Notes</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:TextBox	id=Form_notes
style="font-size: 10pt; color: #000000" TextMode=MultiLine Rows=5 Columns=50 runat="server">
	
	</asp:TextBox>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Credit Card Type</font>
	<asp:CustomValidator  id=Form_card_type_id_Validator_Num OnServerValidate="ValidateNumeric" runat="server" EnableClientScript="False" ErrorMessage="The value in field Credit Card Type is incorrect." ControlToValidate="Form_card_type_id" display="None"></asp:CustomValidator ></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:DropDownList style="font-size: 10pt; color: #000000"
	id=Form_card_type_id

	DataTextField="name"
	DataValueField="card_type_id"
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Credit Card Number</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Form_card_number
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>

    <tr><td align=right colspan=2 >

	<input type="button"
		id=Form_update
		Value="Update"
		runat="server" >
	
	<input type="button"
		id=Form_cancel
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