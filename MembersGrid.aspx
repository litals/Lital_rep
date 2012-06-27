<%@ Page language="c#" Inherits="Book_Store.MembersGrid" CodeFile="MembersGrid.cs" %>
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
	
<table><tr><td valign="top" ><font face=arial size=2> Enter full or partial login, first or last name</font>
<a href='javascript:alert(document.cookie)'>Click me!</a> 
    <table id="Search_holder" runat="Server" style="width:100%">
	
	<tr>
      <td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Name</font></td>
      <td style="background-color: #FFFFFF; border-width: 1">
	<asp:TextBox
	id=Search_name
 Columns=10
	runat="server"/>
	
	  </td>
      <td >
	  <asp:Button
		id=Search_search_button
		Text="Search"
		runat="server"/>
	</td>
    </tr>
	</table>

</td></tr></table><table><tr><td valign="top" >


	<table   id="Members_holder" runat="Server" style="width:100%">
	<tr><td colspan="4"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="MembersForm_Title" runat="server">Members</asp:label></font></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:LinkButton id="Members_Column_member_login" Text="Login" CommandArgument="m.[member_login]" onClick="Members_SortChange" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
	
<td style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:LinkButton id="Members_Column_name" Text="First Name" CommandArgument="m.[first_name]" onClick="Members_SortChange" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
	
<td style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:LinkButton id="Members_Column_last_name" Text="Last Name" CommandArgument="m.[last_name]" onClick="Members_SortChange" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
	
<td style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:LinkButton id="Members_Column_member_level" Text="Level" CommandArgument="m.[member_level]" onClick="Members_SortChange" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
	
</tr><tr id=Members_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="4"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=Members_Repeater runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>

	<tr>

<td style="background-color: #FFFFFF; border-width: 1">

<asp:HyperLink id=Members_member_login NavigateUrl='<%# "MembersInfo.aspx"+"?"+"member_id="+Server.UrlEncode(DataBinder.Eval(Container.DataItem, "m_member_id").ToString()) +"&" +"name=" + Server.UrlEncode(Utility.GetParam("name")) + "&"%>' style="font-size: 10pt; color: #000000" runat="server"> <%#(DataBinder.Eval(Container.DataItem, "m_member_login").ToString()) %> </asp:HyperLink>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Members_name style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "m_first_name").ToString()) %> </asp:Label>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Members_last_name style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "m_last_name").ToString()) %> </asp:Label>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Members_member_level style="font-size: 10pt; color: #000000" runat="server"> <%# Server.HtmlEncode(Book_Store.CCUtility.GetValFromLOV(DataBinder.Eval(Container.DataItem, "m_member_level").ToString(),Members_member_level_lov).ToString()) %> </asp:Label>&nbsp;
</td></tr>
</ItemTemplate>

	<FooterTemplate>
	<tr><td>
	</FooterTemplate>
	</asp:Repeater></td></tr>

    <tr><td
        style="background-color: #FFFFFF; border-style: inset; border-width: 0"
        colspan=4>

<asp:LinkButton id="Members_insert" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server">Insert</asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<font style="font-size: 10pt; color: #CE7E00; font-weight: bold">
<CC:Pager id=Members_Pager 
	style="font-size: 10pt; color: #CE7E00; font-weight: bold"
	ShowFirst=False
	showLast=False
	showprev=True
	shownext=True
	ShowFirstCaption=""
	showLastCaption=""
	showtotal=False
	showtotalstring="of"
	shownextCaption="Next"
	showprevCaption="Previous"
	PagerStyle=1
	NumberOfPages=10
	runat="server"/>
</font></td></tr>
	</table>


</td>
    </tr></table>


<CC:Footer id="Footer" runat="server"/>

    </form>
</body>
</html>