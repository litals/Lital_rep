<%@ Page language="c#" Inherits="Book_Store.MembersRecord" CodeFile="MembersRecord.cs" %>
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
	<input type=hidden id=p_Members_member_id runat=server />
	
<table><tr><td valign="top" >

<table  id="Members_holder" runat="Server" style="width:100%">
	<tr><td colspan=2 style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="MembersForm_Title" runat="server">Members</asp:label></font><br>
	</td></tr>
	<tr><td colspan="2" style="background-color: #FFFFFF; border-width: 1">
	<asp:Label id=Members_ValidationSummary style="background-color: #FFFFFF; border-width: 1" runat="server" Visible="false"></asp:Label>

	<input type="Hidden" id="Members_member_id" value="" runat="server">
</td></tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Login*</font>
	<asp:RequiredFieldValidator id=Members_member_login_Validator_Req runat="server" ErrorMessage="The value in field Login* is required." ControlToValidate="Members_member_login" display="None" EnableClientScript="False"></asp:RequiredFieldValidator></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Members_member_login
 Columns=20
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Password*</font>
	<asp:RequiredFieldValidator id=Members_member_password_Validator_Req runat="server" ErrorMessage="The value in field Password* is required." ControlToValidate="Members_member_password" display="None" EnableClientScript="False"></asp:RequiredFieldValidator></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Members_member_password
 TextMode=Password Columns=20
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Level*</font>
	<asp:RequiredFieldValidator id=Members_member_level_Validator_Req runat="server" ErrorMessage="The value in field Level* is required." ControlToValidate="Members_member_level" display="None" EnableClientScript="False"></asp:RequiredFieldValidator>
	<asp:CustomValidator  id=Members_member_level_Validator_Num OnServerValidate="ValidateNumeric" runat="server" EnableClientScript="False" ErrorMessage="The value in field Level* is incorrect." ControlToValidate="Members_member_level" display="None"></asp:CustomValidator ></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:DropDownList style="font-size: 10pt; color: #000000"
	id=Members_member_level

	DataTextField=""
	DataValueField=""
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">First Name*</font>
	<asp:RequiredFieldValidator id=Members_name_Validator_Req runat="server" ErrorMessage="The value in field First Name* is required." ControlToValidate="Members_name" display="None" EnableClientScript="False"></asp:RequiredFieldValidator></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Members_name
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Last Name*</font>
	<asp:RequiredFieldValidator id=Members_last_name_Validator_Req runat="server" ErrorMessage="The value in field Last Name* is required." ControlToValidate="Members_last_name" display="None" EnableClientScript="False"></asp:RequiredFieldValidator></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Members_last_name
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Email*</font>
	<asp:RequiredFieldValidator id=Members_email_Validator_Req runat="server" ErrorMessage="The value in field Email* is required." ControlToValidate="Members_email" display="None" EnableClientScript="False"></asp:RequiredFieldValidator></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Members_email
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Phone</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Members_phone
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Address</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Members_address
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Notes</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:TextBox	id=Members_notes
style="font-size: 10pt; color: #000000" TextMode=MultiLine Rows=5 Columns=50 runat="server">
	
	</asp:TextBox>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Credit Card Type</font>
	<asp:CustomValidator  id=Members_card_type_id_Validator_Num OnServerValidate="ValidateNumeric" runat="server" EnableClientScript="False" ErrorMessage="The value in field Credit Card Type is incorrect." ControlToValidate="Members_card_type_id" display="None"></asp:CustomValidator ></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:DropDownList style="font-size: 10pt; color: #000000"
	id=Members_card_type_id

	DataTextField="name"
	DataValueField="card_type_id"
	runat="server"/>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Credit Card Number</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Members_card_number
 Columns=50
	runat="server"/>
&nbsp;</td>
	</tr>

    <tr><td align=right colspan=2 >

	<input type="button"
		id=Members_insert
		Value="Insert"
		runat="server" >
	
	<input type="button"
		id=Members_update
		Value="Update"
		runat="server" >
	
	<input type="button"
		id=Members_delete
		Value="Delete"
		runat="server" >
	
	<input type="button"
		id=Members_cancel
		Value="Cancel"
		runat="server" >
	
    </td></tr>

	</table>

<SCRIPT Language="JavaScript">
if (document.forms["Members"])
document.Members.onsubmit=delconf;
function delconf() {
if (document.Members.FormAction.value == 'delete')
  return confirm('Delete record?');
}
</SCRIPT>
</td>
    </tr></table>


<CC:Footer id="Footer" runat="server"/>

    </form>
</body>
</html>