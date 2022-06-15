<%@ Page Title="" Language="C#" MasterPageFile="~/Master/mymaster.Master" AutoEventWireup="true" CodeBehind="Price.aspx.cs" Inherits="News_Magazine_Website.Pages.Price" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="PriceTable">
        <thead>
        <tr>
            <th>نماد</th>
            <th>🇺🇸USD</th>
            <th>🇪🇺EUR</th>
            <th>🇦🇪AED</th>
            <th>🇨🇳CNY</th>
            <th>🇷🇺RUB</th>
            <th>🇹🇷TRY</th>
            <th>🇨🇦CAD</th>
            <th>🇬🇧GBP</th>
            <th>🇶🇦QAR</th>
            <th>🇸🇦SAR</th>
        </tr>
        </thead>
        <tbody>
        <tr>
            <td>نرخ ارز</td>
            <td><%: myDeserializedClass.data.prices.USD.current %></td>
            <td><%: myDeserializedClass.data.prices.EUR.current %></td>
            <td><%: myDeserializedClass.data.prices.AED.current %></td>
            <td><%: myDeserializedClass.data.prices.CNY.current %></td>
            <td><%: myDeserializedClass.data.prices.RUB.current %></td>
            <td><%: myDeserializedClass.data.prices.TRY.current %></td>
            <td><%: myDeserializedClass.data.prices.CAD.current %></td>
            <td><%: myDeserializedClass.data.prices.GBP.current %></td>
            <td><%: myDeserializedClass.data.prices.QAR.current %></td>
            <td><%: myDeserializedClass.data.prices.SAR.current %></td>
            
        </tr>
        <tr>
            <td>تغییر قیمت</td>
            <td><%: myDeserializedClass.data.prices.USD.changePrice %></td>
            <td><%: myDeserializedClass.data.prices.EUR.changePrice %></td>
            <td><%: myDeserializedClass.data.prices.AED.changePrice %></td>
            <td><%: myDeserializedClass.data.prices.CNY.changePrice %></td>
            <td><%: myDeserializedClass.data.prices.RUB.changePrice %></td>
            <td><%: myDeserializedClass.data.prices.TRY.changePrice %></td>
            <td><%: myDeserializedClass.data.prices.CAD.changePrice %></td>
            <td><%: myDeserializedClass.data.prices.GBP.changePrice %></td>
            <td><%: myDeserializedClass.data.prices.QAR.changePrice %></td>
            <td><%: myDeserializedClass.data.prices.SAR.changePrice %></td>
        </tr>
        <tr>
            <td>درصد تغییر</td>
            <td><%: myDeserializedClass.data.prices.USD.changePercent %>%</td>
            <td><%: myDeserializedClass.data.prices.EUR.changePercent %>%</td>
            <td><%: myDeserializedClass.data.prices.AED.changePercent %>%</td>
            <td><%: myDeserializedClass.data.prices.CNY.changePercent %>%</td>
            <td><%: myDeserializedClass.data.prices.RUB.changePercent %>%</td>
            <td><%: myDeserializedClass.data.prices.TRY.changePercent %>%</td>
            <td><%: myDeserializedClass.data.prices.CAD.changePercent %>%</td>
            <td><%: myDeserializedClass.data.prices.GBP.changePercent %>%</td>
            <td><%: myDeserializedClass.data.prices.QAR.changePercent %>%</td>
            <td><%: myDeserializedClass.data.prices.SAR.changePercent %>%</td>
        </tr>
        </tbody>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
