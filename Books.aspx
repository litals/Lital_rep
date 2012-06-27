<%@ Page language="c#" Inherits="Book_Store.Books" CodeFile="Books.cs" %>
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
	<input type=hidden id=p_Total_item_id runat=server />
	
<table><tr><td valign="top" >


    <table id="Search_holder" runat="Server" style="width:100%">
	
	<tr>
      <td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Category</font></td>
      <td style="background-color: #FFFFFF; border-width: 1">
	<asp:DropDownList style="font-size: 10pt; color: #000000"
	id=Search_category_id

	DataTextField="name"
	DataValueField="category_id"
	runat="server"/>
	
	  </td></tr><tr><td style="background-color: #FFEAC5; border-style: inset; border-width: 0"><font style="font-size: 10pt; color: #000000">Title</font></td>
      <td style="background-color: #FFFFFF; border-width: 1">
	<asp:TextBox
	id=Search_name
 Columns=10
	runat="server"/>
	
	  </td></tr><tr>
      <td align="right" colspan="3">
	  <asp:Button
		id=Search_search_button
		Text="Search"
		runat="server"/>
	</td>
    </tr>
	</table>

</td><td valign="top" >


  <table id="AdvMenu_holder" runat="Server" style="width:100%">
  
  <tr>
  
    <td style="background-color: #FFFFFF; border-width: 1">
    <asp:HyperLink NavigateUrl="AdvSearch.aspx" id=AdvMenu_Field1
style="font-size: 10pt; color: #000000" runat="server">Advanced Search</asp:HyperLink></td>
    </tr>
  </table>

</td></tr></table><table><tr><td valign="top" >


	<table   id="Total_holder" runat="Server" style="width:100%">
	<tr><td colspan="2"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="TotalForm_Title" runat="server"></asp:label></font></td></tr>
<tr id=Total_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="1"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=Total_Repeater runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>

<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:Label Text="Items found:" id="item_id_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/>
</td>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Total_item_id style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "i_item_id").ToString()) %> </asp:Label>&nbsp;
</td></tr></ItemTemplate>

	<SeparatorTemplate>
		<tr><td colspan=2style="background-color: #FFFFFF; border-width: 1">&nbsp;</td></tr>
	</SeparatorTemplate>

	<FooterTemplate>
	<tr><td>
	</FooterTemplate>
	</asp:Repeater></td></tr>

	</table>


</td></tr></table><table><tr><td valign="top" >


	<table   id="Results_holder" runat="Server" style="width:100%">
	<tr><td colspan="1"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="ResultsForm_Title" runat="server">Search Results</asp:label></font></td></tr>
<tr id=Results_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="5"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=Results_Repeater onitemdatabound="Results_Repeater_ItemDataBound" runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>
<tr><td><table width="100%" style="width:100%">
<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="" id="name_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

<asp:HyperLink id=Results_name NavigateUrl='<%# "BookDetail.aspx"+"?"+"item_id="+Server.UrlEncode(DataBinder.Eval(Container.DataItem, "i_item_id").ToString()) +"&" +"author=" + Server.UrlEncode(Utility.GetParam("author")) + "&category_id=" + Server.UrlEncode(Utility.GetParam("category_id")) + "&name=" + Server.UrlEncode(Utility.GetParam("name")) + "&pricemax=" + Server.UrlEncode(Utility.GetParam("pricemax")) + "&pricemin=" + Server.UrlEncode(Utility.GetParam("pricemin")) + "&"%>' style="font-size: 10pt; color: #000000" runat="server"> <%#DataBinder.Eval(Container.DataItem, "i_name") %> </asp:HyperLink>&nbsp;
</td></tr>
<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="" id="author_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Results_author style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "i_author").ToString()) %> </asp:Label>&nbsp;
</td></tr>
<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="Price" id="price_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Results_price style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "i_price").ToString()) %> </asp:Label>&nbsp;
</td></tr>
<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="Category" id="category_id_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

 
<input type=hidden id=Results_image_url runat="server" value=<%# DataBinder.Eval(Container.DataItem, "i_image_url") %>>
 <asp:Label id=Results_category_id style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "c_name").ToString()) %> </asp:Label>&nbsp;
</td></tr></table></td>
</tr>
</table></td></tr></ItemTemplate>

	<SeparatorTemplate>
		<tr><td colspan=2style="background-color: #FFFFFF; border-width: 1">&nbsp;</td></tr>
	</SeparatorTemplate>

	<FooterTemplate>
	<tr><td>
	</FooterTemplate>
	</asp:Repeater></td></tr>

    <tr><td
        style="background-color: #FFFFFF; border-style: inset; border-width: 0"
        colspan=1>


<font style="font-size: 10pt; color: #CE7E00; font-weight: bold">
<CC:Pager id=Results_Pager 
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