<%@ Page language="c#" Inherits="Book_Store.Login" CodeFile="Login.cs" %>
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
	<center>
<table><tr><td valign="top" >


<table  id="Login_holder" runat="Server" style="width:100%">
<tr><td colspan=2 style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="LoginForm_Title" runat="server">Enter login and password</asp:label></font></td></tr>
<tr id=Login_trname runat=server>
<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Login</font></td>
<td style="background-color: #FFFFFF; border-width: 1"><asp:TextBox id=Login_name runat="server"/></td>
</tr>
<tr id=Login_trpassword runat=server>
<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Password</font></td>
<td style="background-color: #FFFFFF; border-width: 1"><asp:TextBox TextMode="Password" id=Login_password runat="server"/></td>
</tr>


<tr><td colspan=2 style="background-color: #FFFFFF; border-style: inset; border-width: 0">
    <asp:Label id=Login_labelname
		style="font-size: 10pt; color: #CE7E00; font-weight: bold"
		runat="server"/>
    <asp:Button
		id=Login_login
		runat="server"/>
    &nbsp;&nbsp;&nbsp;
    <asp:Label
		style="font-size: 10pt; color: #CE7E00; font-weight: bold"
        Text="Login or Password is incorrect."
		id=Login_message
        visible=false
        runat="server"/>
</td></tr>
</table>

guest/guest<br>
admin/admin
</td>
    </tr></table>


<CC:Footer id="Footer" runat="server"/>

    </form>
</body>
</html>