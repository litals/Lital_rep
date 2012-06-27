<%@ Page language="c#" Inherits="Book_Store.ShoppingCart" CodeFile="ShoppingCart.cs" %>
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
	<input type=hidden id=p_Items_order_id runat=server />
	<input type=hidden id=p_Member_member_id runat=server />
	
<table><tr><td valign="top">

<table  id="Member_holder" runat="Server" style="width:100%">
	<tr><td colspan=2 style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="MemberForm_Title" runat="server">User Information</asp:label></font><br>
	</td></tr>
	<tr><td colspan="2" style="background-color: #FFFFFF; border-width: 1">
	<asp:Label id=Member_ValidationSummary style="background-color: #FFFFFF; border-width: 1" runat="server" Visible="false"></asp:Label>

	<input type="Hidden" id="Member_member_id" value="" runat="server">
</td></tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Login</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:HyperLink id=Member_member_login
style="font-size: 10pt; color: #000000"	runat="server">
	
	</asp:HyperLink>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">First Name</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Member_name
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Last Name</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Member_last_name
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Address</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Member_address
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Email</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Member_email
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Phone</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Member_phone
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>

	</table>


</td><td valign="top">


	<table   id="Items_holder" runat="Server" style="width:100%">
	<tr><td colspan="6"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="ItemsForm_Title" runat="server">Items</asp:label></font></td></tr>
<tr>
<td 
style="background-color: #FFFFFF; border-style: inset; border-width: 0">
</td>
<td 
style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:Label	id="Items_Column_order_id"	Text="Order #" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
<td 
style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:Label	id="Items_Column_item_id"	Text="Item" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
<td 
style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:Label	id="Items_Column_price"	Text="Price" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
<td 
style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:Label	id="Items_Column_quantity"	Text="Quantity" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
<td 
style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:Label	id="Items_Column_sub_total"	Text="Total" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
</tr><tr id=Items_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="6"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=Items_Repeater runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>

	<tr>

<td style="background-color: #FFFFFF; border-width: 1">

<asp:HyperLink id=Items_Field1 NavigateUrl='<%# "ShoppingCartRecord.aspx"+"?"+"order_id="+Server.UrlEncode(DataBinder.Eval(Container.DataItem, "order_id").ToString()) +"&" +""%>' style="font-size: 10pt; color: #000000" runat="server">Details</asp:HyperLink>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Items_order_id style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "order_id").ToString()) %> </asp:Label>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Items_item_id style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "name").ToString()) %> </asp:Label>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Items_price style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "price").ToString()) %> </asp:Label>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Items_quantity style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "quantity").ToString()) %> </asp:Label>&nbsp;
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Items_sub_total style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "sub_total").ToString()) %> </asp:Label>&nbsp;
</td></tr>
</ItemTemplate>

	<FooterTemplate>
	<tr><td>
	</FooterTemplate>
	</asp:Repeater></td></tr>

	</table>





	<table   id="Total_holder" runat="Server" style="width:100%">
	<tr><td colspan="1"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="TotalForm_Title" runat="server"></asp:label></font></td></tr>
<tr>
<td 
style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:Label	id="Total_Column_sub_total"	Text="Total" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
</tr><tr id=Total_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="1"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=Total_Repeater runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>

	<tr>

<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Total_sub_total style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "sub_total").ToString()) %> </asp:Label>&nbsp;
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