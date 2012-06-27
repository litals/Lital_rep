<%@ Control Language="c#" Inherits="Book_Store.CCPager" CodeFile="CCPager.cs" %>
<asp:label id="lblFirst" runat="server" visible=false>
</asp:label>
<asp:linkbutton id="lnkFirst" runat="server"  visible=false onclick="lnkFirst_Click">
</asp:linkbutton>
<asp:label id="lblPrev" runat="server"  visible=false>
</asp:label>
<asp:linkbutton id="lnkPrev" runat="server" visible=false onclick="lnkPrev_Click">
</asp:linkbutton>
<asp:label id="OpenPar" runat="server">
	[</asp:label><asp:label id="Current"  visible=false runat="server"></asp:label>
<asp:repeater id="Repeater1" OnItemCommand="Repeater1_ItemCommand" OnItemDataBound="Repeater1_ItemDataBound" runat="server" visible=false>
	<ItemTemplate>
		<asp:LinkButton id="LinkButton1" runat="server" enabled=<%# DataBinder.Eval(Container, "DataItem.Enabled")%> CommandArgument=<%# DataBinder.Eval(Container, "DataItem.Page")%>><%# DataBinder.Eval(Container, "DataItem.Page")%></asp:linkbutton>
	</ItemTemplate>
</asp:repeater>
<asp:label id="lblShowTotal" runat="server" visible=false>
</asp:label>
<asp:label id="ClosePar" runat="server">
	]</asp:label>
	<asp:label id="lblNext" runat="server" visible=false></asp:label>
	<asp:linkbutton id="lnkNext" runat="server" visible=false onclick="lnkNext_Click"></asp:linkbutton>
	<asp:label id="lblLast" runat="server" visible=false></asp:label>
	<asp:linkbutton id="lnkLast" runat="server" visible=false onclick="lnkLast_Click"></asp:linkbutton>