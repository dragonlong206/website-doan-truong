<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="WebDoanHoi_layout.wuc.header" %>
<img src="../images/top_banner.jpg" alt="banner" />
<%--<div id="navigation">
    <ul>
        <li><a href="#">Trang chủ</a></li>
        <li><a href="#">Hệ thống tổ chức</a></li>
        <li><a href="#">Nhịp sống trẻ</a></li>
        <li><a href="#">Học tập - nghiên cứu khoa học</a></li>
        <li><a href="#">Cuộc vận động làm theo lời Bác</a></li>
        <li><a href="#">Hỗ trợ sinh viên</a></li>
        <li><a href="#">Tiện ích</a></li>
        <li><a href="#">Văn bản</a></li>
    </ul>
</div>--%>
<!-- navigation end -->
<div id="navigation">
            <asp:Menu ID="Menu1" runat="server" ForeColor="White" 
            Orientation="Horizontal" Width="1024px">
                <LevelMenuItemStyles>
                </LevelMenuItemStyles>
            <DynamicHoverStyle BackColor="White" ForeColor="#0066FF" />
            <DynamicMenuStyle BackColor="#3399FF" />
            
            <Items>
                <asp:MenuItem NavigateUrl="trangchu.aspx" Text="Trang chủ" Value="Trang chủ">
                </asp:MenuItem>
                <asp:MenuItem Text="Giới thiệu" Value="Giới thiệu" NavigateUrl="gioithieu.aspx">
                    <asp:MenuItem Text="Đoàn TNCS HCM" Value="Đoàn TNCS HCM" 
                        NavigateUrl="gioithieu.aspx?id=1"></asp:MenuItem>
                    <asp:MenuItem Text="Đoàn TNCS HCM - Trường ĐH-KHTN" 
                        Value="Đoàn TNCS HCM - Trường ĐH-KHTN" NavigateUrl="gioithieu.aspx?id=2"></asp:MenuItem>
                    <asp:MenuItem Text="Điều lệ Đoàn" Value="Điều lệ Đoàn" 
                        NavigateUrl="gioithieu.aspx?id=3"></asp:MenuItem>
                    <asp:MenuItem Text="Hội SV VN" Value="Hội SV VN" 
                        NavigateUrl="gioithieu.aspx?id=4"></asp:MenuItem>
                    <asp:MenuItem Text="Hội SV VN - Trường ĐH-KHTN" 
                        Value="Hội SV VN - Trường ĐH-KHTN" NavigateUrl="gioithieu.aspx?id=5"></asp:MenuItem>
                    <asp:MenuItem Text="Điều lệ Hội" Value="Điều lệ Hội" 
                        NavigateUrl="gioithieu.aspx?id=6"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Hệ thống tổ chức" Value="Hệ thống tổ chức"></asp:MenuItem>
                <asp:MenuItem Text="Nhịp sống trẻ" Value="Nhịp sống trẻ" 
                    NavigateUrl="nhipsongtre.aspx?id=1">
                    <asp:MenuItem Text="Thời sự giới trẻ" Value="Thời sự giới trẻ" 
                        NavigateUrl="nhipsongtre.aspx?id=1&amp;idLBV=1"></asp:MenuItem>
                    <asp:MenuItem Text="Kỹ năng sống" Value="Kỹ năng sống" 
                        NavigateUrl="nhipsongtre.aspx?id=1&amp;idLBV=2"></asp:MenuItem>
                    <asp:MenuItem Text="Góc chia sẻ" Value="Góc chia sẻ" 
                        NavigateUrl="nhipsongtre.aspx?id=1&amp;idLBV=3"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Học tập nghiên cứu khoa học" 
                    Value="Học tập nghiên cứu khoa học" NavigateUrl="htnckh.aspx?id=2">
                    <asp:MenuItem Text="Ngân hàng đề tài" Value="Ngân hàng đề tài" 
                        NavigateUrl="htnckh.aspx?id=2&amp;idLBV=1"></asp:MenuItem>
                    <asp:MenuItem Text="Biểu mẫu" Value="Biểu mẫu" 
                        NavigateUrl="htnckh.aspx?id=2&amp;idLBV=2"></asp:MenuItem>
                    <asp:MenuItem Text="Kế hoạch thông báo" Value="Kế hoạch thông báo" 
                        NavigateUrl="htnckh.aspx?id=2&amp;idLBV=3">
                    </asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Học tập làm theo lời Bác" Value="Học tập làm theo lời Bác" 
                    NavigateUrl="htltlb.aspx?id=3">
                    <asp:MenuItem Text="Chương trình hoạt động" Value="Chương trình hoạt động" 
                        NavigateUrl="htltlb.aspx?id=3&amp;LBV=1">
                    </asp:MenuItem>
                    <asp:MenuItem Text="Gương sáng ĐH-KHTN" Value="Gương sáng ĐH-KHTN" 
                        NavigateUrl="htltlb.aspx?id=3&amp;LBV=2">
                    </asp:MenuItem>
                    <asp:MenuItem Text="Đoàn viên làm theo lời Bác" 
                        Value="Đoàn viên làm theo lời Bác" 
                        NavigateUrl="htltlb.aspx?id=3&amp;LBV=3"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Hỗ trợ sinh viên" Value="Hỗ trợ sinh viên" 
                    NavigateUrl="htltlb.aspx?id=4">
                    <asp:MenuItem Text="Việc làm" Value="Việc làm" 
                        NavigateUrl="htltlb.aspx?id=4&amp;idLBV=1"></asp:MenuItem>
                    <asp:MenuItem Text="Nhà trọ" Value="Nhà trọ" 
                        NavigateUrl="htltlb.aspx?id=4&amp;idLBV=2"></asp:MenuItem>
                    <asp:MenuItem Text="Học bổng" Value="Học bổng" 
                        NavigateUrl="htltlb.aspx?id=4&amp;idLBV=3"></asp:MenuItem>
                    <asp:MenuItem Text="Kỹ năng mềm" Value="Kỹ năng mềm" 
                        NavigateUrl="htltlb.aspx?id=4&amp;idLBV=4"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Tiện ích" Value="Tiện ích" NavigateUrl="tienich.aspx?id=5">
                    <asp:MenuItem Text="Lịch làm việc" Value="Lịch làm việc" 
                        NavigateUrl="tienich.aspx?id=5&amp;idLBV=1"></asp:MenuItem>
                    <asp:MenuItem Text="Đăng ký mượn phòng" Value="Đăng ký mượn phòng" 
                        NavigateUrl="tienich.aspx?id=5&amp;idLBV=2">
                    </asp:MenuItem>
                    <asp:MenuItem Text="Hình ảnh hoạt động" Value="Hình ảnh hoạt động" 
                        NavigateUrl="tienich.aspx?id=5&amp;idLBV=3">
                    </asp:MenuItem>
                    <asp:MenuItem Text="Bài hát" Value="Bài hát" 
                        NavigateUrl="tienich.aspx?id=5&amp;idLBV=4"></asp:MenuItem>
                </asp:MenuItem>
            </Items>
        </asp:Menu>  
</div>
<div id="menu">
    <asp:Label ID="txtTime" runat="server"></asp:Label>
    &nbsp;-
    Văn bản - tài liệu
</div>

