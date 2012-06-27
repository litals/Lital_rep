<%@ Page language="c#" Inherits="Book_Store.MembersInfo" CodeFile="MembersInfo.cs" %>
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
	<input type=hidden id=p_Record_member_id runat=server />
	<input type=hidden id=p_Orders_order_id runat=server />
	
<table><tr><td valign="top" >

<table  id="Record_holder" runat="Server" style="width:100%">
	<tr><td colspan=2 style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="RecordForm_Title" runat="server">Member Info</asp:label></font><br>
	</td></tr>
	<tr><td colspan="2" style="background-color: #FFFFFF; border-width: 1">
	<asp:Label id=Record_ValidationSummary style="background-color: #FFFFFF; border-width: 1" runat="server" Visible="false"></asp:Label>

	<input type="Hidden" id="Record_member_id" value="" runat="server">
</td></tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Login</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:HyperLink id=Record_member_login
style="font-size: 10pt; color: #000000"	runat="server">
	
	</asp:HyperLink>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Level</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Record_member_level
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">First Name</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Record_name
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Last Name</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Record_last_name
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Email</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Record_email
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Phone</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Record_phone
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Address</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Record_address
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Notes</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Record_notes
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>

	</table>


</td></tr></table><table><tr><td valign="top" >


	<table   id="Orders_holder" runat="Server" style="width:100%">
	<tr><td colspan="3"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="OrdersForm_Title" runat="server">Shopping Cart</asp:label></font></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:LinkButton id="Orders_Column_order_id" Text="Order" CommandArgument="o.[order_id]" onClick="Orders_SortChange" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
	
<td style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:LinkButton id="Orders_Column_item_id" Text="Item" CommandArgument="i.[name]" onClick="Orders_SortChange" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
	
<td style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:LinkButton id="Orders_Column_quantity" Text="Quantity" CommandArgument="o.[quantity]" onClick="Orders_SortChange" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
	
</tr><tr id=Orders_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="3"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=Orders_Repeater runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>

	<tr>

<td style="background-color: #FFFFFF; border-width: 1">

<asp:HyperLink id=Orders_order_id NavigateUrl='<%# "OrdersRecord.aspx"+"?"+"order_id="+Server.UrlEncode(DataBinder.Eval(Container.DataItem, "o_order_id").ToString()) +"&" +"member_id=" + Server.UrlEncode(Utility.GetParam("member_id")) + "&"%>' style="font-size: 10pt; color: #000000" runat="server"> <%#Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "o_order_id").ToString()) %> </asp:HyperLink>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Orders_item_id style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "i_name").ToString()) %> </asp:Label>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Orders_quantity style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "o_quantity").ToString()) %> </asp:Label>&nbsp;
</td></tr>
</ItemTemplate>

	<FooterTemplate>
	<tr><td>
	</FooterTemplate>
	</asp:Repeater></td></tr>

	</table>


</td>
    </tr></table>


<CC:Footer id="Footer" runat="server"/>

    </form>
</body>
</html>