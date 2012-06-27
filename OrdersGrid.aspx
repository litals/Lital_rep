<%@ Page language="c#" Inherits="Book_Store.OrdersGrid" CodeFile="OrdersGrid.cs" %>
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
	
	<tr>
      <td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Item</font></td>
      <td style="background-color: #FFFFFF; border-width: 1">
	<asp:DropDownList style="font-size: 10pt; color: #000000"
	id=Search_item_id

	DataTextField="name"
	DataValueField="item_id"
	runat="server"/>
	
	  </td><td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Member</font></td>
      <td style="background-color: #FFFFFF; border-width: 1">
	<asp:DropDownList style="font-size: 10pt; color: #000000"
	id=Search_member_id

	DataTextField="member_login"
	DataValueField="member_id"
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


	<table   id="Orders_holder" runat="Server" style="width:100%">
	<tr><td colspan="5"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="OrdersForm_Title" runat="server">Orders</asp:label></font></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:Label id="Orders_Column_Field1" Text="Edit"  style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
	
<td style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:LinkButton id="Orders_Column_item_id" Text="Item" CommandArgument="i.[name]" onClick="Orders_SortChange" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
	
<td style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:LinkButton id="Orders_Column_member_id" Text="Member" CommandArgument="m.[member_login]" onClick="Orders_SortChange" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
	
<td style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:LinkButton id="Orders_Column_quantity" Text="Quantity" CommandArgument="o.[quantity]" onClick="Orders_SortChange" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
	
</tr><tr id=Orders_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="5"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=Orders_Repeater runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>

	<tr>

<td style="background-color: #FFFFFF; border-width: 1">

<asp:HyperLink id=Orders_Field1 NavigateUrl='<%# "OrdersRecord.aspx"+"?"+"order_id="+Server.UrlEncode(DataBinder.Eval(Container.DataItem, "o_order_id").ToString()) +"&" +"item_id=" + Server.UrlEncode(Utility.GetParam("item_id")) + "&member_id=" + Server.UrlEncode(Utility.GetParam("member_id")) + "&"%>' style="font-size: 10pt; color: #000000" runat="server">Edit</asp:HyperLink>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Orders_item_id style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "i_name").ToString()) %> </asp:Label>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Orders_member_id style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "m_member_login").ToString()) %> </asp:Label>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 
<input type=hidden id=Orders_order_id runat="server" value=<%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "o_order_id").ToString()) %>>
 <asp:Label id=Orders_quantity style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "o_quantity").ToString()) %> </asp:Label>&nbsp;
</td></tr>
</ItemTemplate>

	<FooterTemplate>
	<tr><td>
	</FooterTemplate>
	</asp:Repeater></td></tr>

    <tr><td
        style="background-color: #FFFFFF; border-style: inset; border-width: 0"
        colspan=5>

<asp:LinkButton id="Orders_insert" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server">Insert</asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<font style="font-size: 10pt; color: #CE7E00; font-weight: bold">
<CC:Pager id=Orders_Pager 
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