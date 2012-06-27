<%@ Page language="c#" Inherits="Book_Store.BookDetail" CodeFile="BookDetail.cs" %>
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
	<input type=hidden id=p_Detail_item_id runat=server />
	<input type=hidden id=p_Order_order_id runat=server />
	<input type=hidden id=p_Rating_item_id runat=server />
	
<table><tr><td valign="top" >

<table  id="Detail_holder" runat="Server" style="width:100%">
	<tr><td colspan=2 style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="DetailForm_Title" runat="server">Book Detail</asp:label></font><br>
	</td></tr>
	<tr><td colspan="2" style="background-color: #FFFFFF; border-width: 1">
	<asp:Label id=Detail_ValidationSummary style="background-color: #FFFFFF; border-width: 1" runat="server" Visible="false"></asp:Label>

	<input type="Hidden" id="Detail_item_id" value="" runat="server">
</td></tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Title</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Detail_name
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Author</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Detail_author
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Category</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Detail_category_id
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Price</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Detail_price
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Picture</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:HyperLink id=Detail_image_url
style="font-size: 10pt; color: #000000"	runat="server">
	
	</asp:HyperLink>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Notes</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Detail_notes
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000"></font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:HyperLink id=Detail_product_url
style="font-size: 10pt; color: #000000"	runat="server">
	
	</asp:HyperLink>
&nbsp;</td>
	</tr>

	</table>


</td></tr></table><table><tr><td valign="top" >

<table  id="Order_holder" runat="Server" style="width:100%">
	<tr><td colspan=2 style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="OrderForm_Title" runat="server"></asp:label></font><br>
	</td></tr>
	<tr><td colspan="2" style="background-color: #FFFFFF; border-width: 1">
	<asp:Label id=Order_ValidationSummary style="background-color: #FFFFFF; border-width: 1" runat="server" Visible="false"></asp:Label>

	<input type="Hidden" id="Order_order_id" value="" runat="server">

	<input type="Hidden" id="Order_item_id" value="" runat="server">
</td></tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Quantity</font>
	<asp:RequiredFieldValidator id=Order_quantity_Validator_Req runat="server" ErrorMessage="The value in field Quantity is required." ControlToValidate="Order_quantity" display="None" EnableClientScript="False"></asp:RequiredFieldValidator>
	<asp:CustomValidator  id=Order_quantity_Validator_Num OnServerValidate="ValidateNumeric" runat="server" EnableClientScript="False" ErrorMessage="The value in field Quantity is incorrect." ControlToValidate="Order_quantity" display="None"></asp:CustomValidator ></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:TextBox
	id=Order_quantity
 Columns=10
	Text="1"
	runat="server"/>
&nbsp;</td>
	</tr>

    <tr><td align=right colspan=2 >

	<input type="button"
		id=Order_insert
		Value="Add to Shopping Cart"
		runat="server" >
	
    </td></tr>

	</table>


</td></tr></table><table><tr><td valign="top" >

<table  id="Rating_holder" runat="Server" style="width:100%">
	<tr><td colspan=2 style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="RatingForm_Title" runat="server">Rating</asp:label></font><br>
	</td></tr>
	<tr><td colspan="2" style="background-color: #FFFFFF; border-width: 1">
	<asp:Label id=Rating_ValidationSummary style="background-color: #FFFFFF; border-width: 1" runat="server" Visible="false"></asp:Label>

	<input type="Hidden" id="Rating_item_id" value="" runat="server">

	<input type="Hidden" id="Rating_rating_count" value="" runat="server">
</td></tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Current Rating</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Rating_rating_view
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Total Votes</font></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        
	<asp:Label id=Rating_rating_count_view
style="font-size: 10pt; color: #000000" runat="server">
	
	</asp:Label>
&nbsp;</td>
	</tr>
<tr>
	<td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Your Rating</font>
	<asp:RequiredFieldValidator id=Rating_rating_Validator_Req runat="server" ErrorMessage="The value in field Your Rating is required." ControlToValidate="Rating_rating" display="None" EnableClientScript="False"></asp:RequiredFieldValidator>
	<asp:CustomValidator  id=Rating_rating_Validator_Num OnServerValidate="ValidateNumeric" runat="server" EnableClientScript="False" ErrorMessage="The value in field Your Rating is incorrect." ControlToValidate="Rating_rating" display="None"></asp:CustomValidator ></td>
    	<td style="background-color: #FFFFFF; border-width: 1">
        <asp:DropDownList style="font-size: 10pt; color: #000000"
	id=Rating_rating

	DataTextField=""
	DataValueField=""
	runat="server"/>
&nbsp;</td>
	</tr>

    <tr><td align=right colspan=2 >

	<input type="button"
		id=Rating_update
		Value="Vote"
		runat="server" >
	
    </td></tr>

	</table>


</td>
    </tr></table>


<CC:Footer id="Footer" runat="server"/>

    </form>
</body>
</html>