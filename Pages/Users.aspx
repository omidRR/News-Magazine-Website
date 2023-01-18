<%@ Page Title="" Language="C#" MasterPageFile="~/Master/mymaster.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="News_Magazine_Website.Pages.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>لیست کاربران</title>
    
    <style>
        * {
            font-family: 'Vazirmatn-Regular';
            box-sizing: border-box;
        }

        #myInput {
            background-image: url('/css/searchicon.png');
            background-position: right 10px top 10px;
            background-repeat: no-repeat;
            width: 50%;
            font-size: 16px;
            padding: 12px 125px 12px 20px;
            border: 1px solid #ddd;
            margin: 10px;
            border-radius: 50px;
            transform: translate(-50%, -50%)
        }

        #myTable {
            border-collapse: collapse;
            width: 100%;
            border: 1px solid #ddd;
            font-size: 18px;
        }

        #myTable th, #myTable td {
            text-align: right;
            padding: 12px;
        }

        #myTable tr {
            border-bottom: 1px solid #ddd;
        }

        #myTable tr.header, #myTable tr:hover {
            background-color: #f1f1f1;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <body>

    <h2 align="center">لیست کارکنان شرکت</h2>

    <input type="text" id="myInput" onkeyup="searchtable()" placeholder="جستجو در لیست بر اساس ، کدملی ، نام ونام خانوادگی ، کد پرسنلی و دسته کاری انجام میگردد" title="جستجو در لیست بر اساس ، کدملی ، نام ونام خانوادگی ، کد پرسنلی و دسته کاری انجام میگردد">

    <table id="myTable">
        <tr class="header">
            <th style="width: 20%;">نام و نام خانوادگی</th>
            <th style="width: 20%;">کد ملی</th>
            <th style="width: 20%;">کد پرسنلی</th>
            <th style="width: 20%;">دسته کاری</th>
            <th style="width: 20%;">وضعیت</th>
        </tr>
        <tr>
            <td>محمد جزایری</td>
            <td>0929735277</td>
            <td>10080</td>
            <td>1</td>
            <td>فعال</td>
        </tr>
        <tr>
            <td>دانیال نیزاری</td>
            <td>0049566679</td>
            <td>10081</td>
            <td>1</td>
            <td>غیرفعال</td>
        </tr>
        <tr>
            <td>احمد عظیمی</td>
            <td>0942623770</td>
            <td>10082</td>
            <td>2</td>
            <td>فعال</td>
        </tr>
        <tr>
            <td>محمد بهرامی</td>
            <td>0393534405</td>
            <td>10083</td>
            <td>1</td>
            <td>فعال</td>
        </tr>
        <tr>
            <td>سعید خاتمی</td>
            <td>0174497237</td>
            <td>10084</td>
            <td>1</td>
            <td>فعال</td>
        </tr>
        <tr>
            <td>پوریا احمدی</td>
            <td>0185270743</td>
            <td>10085</td>
            <td>1</td>
            <td>غیر فعال</td>
        </tr>
        <tr>
            <td>دایان صبوری</td>
            <td>0393531405</td>
            <td>10086</td>
            <td>1</td>
            <td>فعال</td>
        </tr>
        <tr>
            <td>پوریا سالمی</td>
            <td>0391584415</td>
            <td>10087</td>
            <td>2</td>
            <td>غیر فعال</td>
        </tr>
        <tr>
            <td>دانیال بهری مفرد</td>
            <td>0929735277</td>
            <td>10088</td>
            <td>1</td>
            <td>فعال</td>
        </tr>
        <tr>
            <td>فرزاد یگانه</td>
            <td>1869735277</td>
            <td>10089</td>
            <td>2</td>
            <td>فعال</td>
        </tr>
        <tr>
            <td>علی شاوردی</td>
            <td>0929735000</td>
            <td>10090</td>
            <td>1</td>
            <td>فعال</td>
        </tr>
        <tr>
            <td>سامان بزرگمنش</td>
            <td>9406525839</td>
            <td>10091</td>
            <td>2</td>
            <td>فعال</td>
        </tr>
    </table>

    <script>
        function searchtable() {
            var input, filter, table, tr, td, i, txtValue;
            input = document.getElementById("myInput");
            filter = input.value;
            table = document.getElementById("myTable");
            tr = table.getElementsByTagName("tr");

            for (i = 0; i < tr.length; i++) {
                td1 = tr[i].getElementsByTagName("td")[0];
                td2 = tr[i].getElementsByTagName("td")[1];
                td3 = tr[i].getElementsByTagName("td")[2];
                td4 = tr[i].getElementsByTagName("td")[3];
                td5 = tr[i].getElementsByTagName("td")[4];
                if (td1 || td2 || td3 || td4 || td5) {
                    txtValue1 = td1.textContent || td1.innerText;
                    txtValue2 = td2.textContent || td2.innerText;
                    txtValue3 = td3.textContent || td3.innerText;
                    txtValue4 = td4.textContent || td4.innerText;
                    txtValue5 = td5.textContent || td5.innerText;
                    if (txtValue1.indexOf(filter) > -1 || txtValue2.indexOf(filter) > -1 || txtValue3.indexOf(filter) > -1 || txtValue4.indexOf(filter) > -1 || txtValue5.indexOf(filter) > -1) {
                        tr[i].style.display = "";
                    } else {
                        tr[i].style.display = "none";
                    }
                }
            }
        }
    </script>

</body>
    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
