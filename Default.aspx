<%@ Page language="c#" Inherits="Book_Store.Default" CodeFile="Default.cs" %>
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
	
<table><tr><td valign="top">


    <table id="Search_holder" runat="Server" style="width:100%">
	<tr><td style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1" colspan="5"><a name="Search"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="SearchForm_Title" runat="server">Search</asp:label></font></a></td></tr>
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




  <table id="AdvMenu_holder" runat="Server" style="width:100%">
  <tr><td colspan="1"  style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="AdvMenuForm_Title" runat="server">More Search Options</asp:label></font></td></tr>
  <tr>
  
    <td style="background-color: #FFFFFF; border-width: 1">
    <asp:HyperLink NavigateUrl="AdvSearch.aspx" id=AdvMenu_Field1
style="font-size: 10pt; color: #000000" runat="server">Advanced search</asp:HyperLink></td>
    </tr>
  </table>
<br>



	<table   id="Categories_holder" runat="Server" style="width:100%">
	<tr><td colspan="1"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="CategoriesForm_Title" runat="server">Categories</asp:label></font></td></tr>
<tr>
<td 
style="background-color: #FFFFFF; border-style: inset; border-width: 0">
<asp:Label	id="Categories_Column_name"	Text="" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td>
</tr><tr id=Categories_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="1"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=Categories_Repeater runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>

	<tr>

<td style="background-color: #FFFFFF; border-width: 1">

<asp:HyperLink id=Categories_name NavigateUrl='<%# "Books.aspx"+"?"+"category_id="+Server.UrlEncode(DataBinder.Eval(Container.DataItem, "c_category_id").ToString()) +"&" +""%>' style="font-size: 10pt; color: #000000" runat="server"> <%#Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "c_name").ToString()) %> </asp:HyperLink>&nbsp;
</td></tr>
</ItemTemplate>

	<FooterTemplate>
	<tr><td>
	</FooterTemplate>
	</asp:Repeater></td></tr>

	</table>

<br>



	<table   id="Specials_holder" runat="Server" style="width:100%">
	<tr><td colspan="1"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="SpecialsForm_Title" runat="server">Weekly Specials</asp:label></font></td></tr>
<tr id=Specials_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="2"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=Specials_Repeater runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>

<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="" id="article_title_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Specials_article_title style="font-size: 10pt; color: #000000" runat="server">  <%# DataBinder.Eval(Container.DataItem, "e_article_title") %> </asp:Label>&nbsp;
</td></tr>
<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="" id="article_desc_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Specials_article_desc style="font-size: 10pt; color: #000000" runat="server">  <%# DataBinder.Eval(Container.DataItem, "e_article_desc") %> </asp:Label>&nbsp;
</td></tr></ItemTemplate>

	<SeparatorTemplate>
		<tr><td colspan=2style="background-color: #FFFFFF; border-width: 1">&nbsp;</td></tr>
	</SeparatorTemplate>

	<FooterTemplate>
	<tr><td>
	</FooterTemplate>
	</asp:Repeater></td></tr>

	</table>


</td><td valign="top"><table width="250"><tr><td></td></tr></table>


	<table   id="Recommended_holder" runat="Server" style="width:100%">
	<tr><td colspan="1"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="RecommendedForm_Title" runat="server">Recommended Titles</asp:label></font></td></tr>
<tr id=Recommended_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="4"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=Recommended_Repeater onitemdatabound="Recommended_Repeater_ItemDataBound" runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>
<tr><td><table width="100%" style="width:100%">
<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="" id="name_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

<asp:HyperLink id=Recommended_name NavigateUrl='<%# "BookDetail.aspx"+"?"+"item_id="+Server.UrlEncode(DataBinder.Eval(Container.DataItem, "i_item_id").ToString()) +"&" +""%>' style="font-size: 10pt; color: #000000" runat="server"> <%#DataBinder.Eval(Container.DataItem, "i_name") %> </asp:HyperLink>&nbsp;
</td></tr>
<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="" id="author_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

 <asp:Label id=Recommended_author style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "i_author").ToString()) %> </asp:Label>&nbsp;
</td></tr>
<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="Price" id="price_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

 
<input type=hidden id=Recommended_image_url runat="server" value=<%# DataBinder.Eval(Container.DataItem, "i_image_url") %>>
 <asp:Label id=Recommended_price style="font-size: 10pt; color: #000000" runat="server">  <%# Server.HtmlEncode(DataBinder.Eval(Container.DataItem, "i_price").ToString()) %> </asp:Label>&nbsp;
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
<CC:Pager id=Recommended_Pager 
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


</td><td valign="top">


	<table   id="What_holder" runat="Server" style="width:100%">
	<tr><td colspan="1"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="WhatForm_Title" runat="server">What We're Reading</asp:label></font></td></tr>
<tr id=What_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="3"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=What_Repeater onitemdatabound="What_Repeater_ItemDataBound" runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>

<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="" id="article_title_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

<asp:HyperLink id=What_article_title NavigateUrl='<%# "BookDetail.aspx"+"?"+"item_id="+Server.UrlEncode(DataBinder.Eval(Container.DataItem, "e_item_id").ToString()) +"&" +""%>' style="font-size: 10pt; color: #000000" runat="server"> <%#DataBinder.Eval(Container.DataItem, "e_article_title") %> </asp:HyperLink>&nbsp;
</td></tr>
<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="" id="article_desc_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

 
<input type=hidden id=What_item_id runat="server" value=<%# DataBinder.Eval(Container.DataItem, "e_item_id") %>>
 <asp:Label id=What_article_desc style="font-size: 10pt; color: #000000" runat="server">  <%# DataBinder.Eval(Container.DataItem, "e_article_desc") %> </asp:Label>&nbsp;
</td></tr></ItemTemplate>

	<SeparatorTemplate>
		<tr><td colspan=2style="background-color: #FFFFFF; border-width: 1">&nbsp;</td></tr>
	</SeparatorTemplate>

	<FooterTemplate>
	<tr><td>
	</FooterTemplate>
	</asp:Repeater></td></tr>

	</table>





	<table   id="New_holder" runat="Server" style="width:100%">
	<tr><td colspan="1"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="NewForm_Title" runat="server">New & Notable</asp:label></font></td></tr>
<tr id=New_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="3"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=New_Repeater onitemdatabound="New_Repeater_ItemDataBound" runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>

<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="" id="article_title_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

<asp:HyperLink id=New_article_title NavigateUrl='<%# "BookDetail.aspx"+"?"+"item_id="+Server.UrlEncode(DataBinder.Eval(Container.DataItem, "e_item_id").ToString()) +"&" +""%>' style="font-size: 10pt; color: #000000" runat="server"> <%#DataBinder.Eval(Container.DataItem, "e_article_title") %> </asp:HyperLink>&nbsp;
</td></tr>
<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="" id="article_desc_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

 
<input type=hidden id=New_item_id runat="server" value=<%# DataBinder.Eval(Container.DataItem, "e_item_id") %>>
 <asp:Label id=New_article_desc style="font-size: 10pt; color: #000000" runat="server">  <%# DataBinder.Eval(Container.DataItem, "e_article_desc") %> </asp:Label>&nbsp;
</td></tr></ItemTemplate>

	<SeparatorTemplate>
		<tr><td colspan=2style="background-color: #FFFFFF; border-width: 1">&nbsp;</td></tr>
	</SeparatorTemplate>

	<FooterTemplate>
	<tr><td>
	</FooterTemplate>
	</asp:Repeater></td></tr>

	</table>





	<table   id="Weekly_holder" runat="Server" style="width:100%">
	<tr><td colspan="1"
        style="background-color: #336699; text-align: Center; border-style: outset; border-width: 1"
><font style="font-size: 12pt; color: #FFFFFF; font-weight: bold"><asp:label id="WeeklyForm_Title" runat="server">This Week's Featured Books</asp:label></font></td></tr>
<tr id=Weekly_no_records runat="server"><td style="background-color: #FFFFFF; border-width: 1" colspan="3"><font style="font-size: 10pt; color: #000000">No records</font></td></tr>
	<tr><td><asp:Repeater id=Weekly_Repeater onitemdatabound="Weekly_Repeater_ItemDataBound" runat="server">
	<HeaderTemplate>
	</td></tr>
	</HeaderTemplate>
	<ItemTemplate>
<tr><td><table width="100%" style="width:100%">
<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="" id="article_title_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

<asp:HyperLink id=Weekly_article_title NavigateUrl='<%# "BookDetail.aspx"+"?"+"item_id="+Server.UrlEncode(DataBinder.Eval(Container.DataItem, "e_item_id").ToString()) +"&" +""%>' style="font-size: 10pt; color: #000000" runat="server"> <%#DataBinder.Eval(Container.DataItem, "e_article_title") %> </asp:HyperLink>&nbsp;
</td></tr>
<tr><td style="background-color: #FFFFFF; border-style: inset; border-width: 0"><asp:Label Text="" id="article_desc_Column_Title" style="font-size: 10pt; color: #CE7E00; font-weight: bold" runat="server"/></td></tr>
<tr>
<td style="background-color: #FFFFFF; border-width: 1">

 
<input type=hidden id=Weekly_item_id runat="server" value=<%# DataBinder.Eval(Container.DataItem, "e_item_id") %>>
 <asp:Label id=Weekly_article_desc style="font-size: 10pt; color: #000000" runat="server">  <%# DataBinder.Eval(Container.DataItem, "e_article_desc") %> </asp:Label>&nbsp;
</td></tr></table></td></tr></ItemTemplate>

	<SeparatorTemplate>
		<tr><td colspan=2style="background-color: #FFFFFF; border-width: 1">&nbsp;</td></tr>
	</SeparatorTemplate>

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