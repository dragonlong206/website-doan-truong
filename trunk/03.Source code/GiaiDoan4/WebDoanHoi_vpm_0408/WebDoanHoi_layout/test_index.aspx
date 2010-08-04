<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test_index.aspx.cs" Inherits="WebDoanHoi_layout.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Homepage</title>
    <link href="css/style-3-col.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="wrapper">
        <div id="header">
            <img src="images/top_banner.jpg" alt="banner" />
            <div id="navigation">
                <ul>
                    <%--- Đoàn Thanh niên Cộng sản Hồ Chí Minh - Hội Sinh viên Việt Nam - Đoàn TNCSHCM trường
                    DHKHTN - Hội Sinh viên Việt Nam trường DHKHTN - Điều lệ Đoàn - Điều lệ Hội--%>
                    <li><a href="#">Trang chủ</a></li>
                    <li><a href="#">Hệ thống tổ chức</a></li>
                    <li><a href="#">Nhịp sống trẻ</a></li>
                    <li><a href="#">Học tập - nghiên cứu khoa học</a></li>
                    <li><a href="#">Cuộc vận động làm theo lời Bác</a></li>
                    <li><a href="#">Hỗ trợ sinh viên</a></li>
                    <li><a href="#">Tiện ích</a></li>
                    <li><a href="#">Văn bản</a></li>
                </ul>
                <div id="search">
                    <input type="text" id="text" value="search this site for..." />
                    <input type="submit" id="button" value="search" />
                </div>
            </div>
            <!-- navigation end -->
            <div id="mar_text">
                <marquee>Thông tin mới nhất ... </marquee>
            </div>
            <!-- mar_text end -->
        </div>
        <!-- header end -->
        <div id="content">
            <div id="posts">
                <div class="post">
                    <div class="post-title">
                        Tiêu đề 1
                    </div>
                    <div class="post-content">
                        Trở về quê hương “Chúng tôi về quê, không phải đi du lịch”, bạn Hoàng Thanh Loan
                        (18 tuổi, Belarus) bày tỏ ngay từ lần đầu đặt chân về đến VN.
                    </div>
                </div>
                <div class="post">
                    <div class="post-title">
                        Tiêu đề 2
                    </div>
                    <div class="post-content">
                        Trở về quê hương “Chúng tôi về quê, không phải đi du lịch”, bạn Hoàng Thanh Loan
                        (18 tuổi, Belarus) bày tỏ ngay từ lần đầu đặt chân về đến VN.
                    </div>
                </div>
                <div class="post">
                    <div class="post-title">
                        Tiêu đề 3
                    </div>
                    <div class="post-content">
                        Trở về quê hương “Chúng tôi về quê, không phải đi du lịch”, bạn Hoàng Thanh Loan
                        (18 tuổi, Belarus) bày tỏ ngay từ lần đầu đặt chân về đến VN.
                    </div>
                </div>
                <div class="post">
                    <div class="post-title">
                        Tiêu đề 1
                    </div>
                    <div class="post-content">
                        Trở về quê hương “Chúng tôi về quê, không phải đi du lịch”, bạn Hoàng Thanh Loan
                        (18 tuổi, Belarus) bày tỏ ngay từ lần đầu đặt chân về đến VN.
                    </div>
                </div>
                <div class="post">
                    <div class="post-title">
                        Tiêu đề 2
                    </div>
                    <div class="post-content">
                        Trở về quê hương “Chúng tôi về quê, không phải đi du lịch”, bạn Hoàng Thanh Loan
                        (18 tuổi, Belarus) bày tỏ ngay từ lần đầu đặt chân về đến VN.
                    </div>
                </div>
                <div class="post">
                    <div class="post-title">
                        Tiêu đề 3
                    </div>
                    <div class="post-content">
                        Trở về quê hương “Chúng tôi về quê, không phải đi du lịch”, bạn Hoàng Thanh Loan
                        (18 tuổi, Belarus) bày tỏ ngay từ lần đầu đặt chân về đến VN.
                    </div>
                </div>
                <div class="post">
                    <div class="post-title">
                        Tiêu đề 1
                    </div>
                    <div class="post-content">
                        Trở về quê hương “Chúng tôi về quê, không phải đi du lịch”, bạn Hoàng Thanh Loan
                        (18 tuổi, Belarus) bày tỏ ngay từ lần đầu đặt chân về đến VN.
                    </div>
                </div>
                <div class="post">
                    <div class="post-title">
                        Tiêu đề 2
                    </div>
                    <div class="post-content">
                        Trở về quê hương “Chúng tôi về quê, không phải đi du lịch”, bạn Hoàng Thanh Loan
                        (18 tuổi, Belarus) bày tỏ ngay từ lần đầu đặt chân về đến VN.
                    </div>
                </div>
                <div class="post">
                    <div class="post-title">
                        Tiêu đề 3
                    </div>
                    <div class="post-content">
                        Trở về quê hương “Chúng tôi về quê, không phải đi du lịch”, bạn Hoàng Thanh Loan
                        (18 tuổi, Belarus) bày tỏ ngay từ lần đầu đặt chân về đến VN.
                    </div>
                </div>
            </div>
            <!-- posts end -->
            <div id="sidebar1">
                <div class="post-title">
                    Tin mới nhất
                </div>
                <div class="post-content">
                    <ul>
                        <li><a href="#">Item 1</a></li>
                        <li><a href="#">Item 1</a></li>
                        <li><a href="#">Item 1</a></li>
                        <li><a href="#">Item 1</a></li>
                        <li><a href="#">Item 1</a></li>
                        <li><a href="#">Item 1</a></li>
                        <li><a href="#">Item 1</a></li>
                    </ul>
                </div>
            </div>
            <!-- sidebar1 end -->
            <div id="sidebar2">
                <img src="images/active_logo.jpg" alt="active logo" />
            </div>
            <!-- sidebar2 end -->
        </div>
        <!-- content end -->
        <div id="footer">
            <p>
                Đoàn TNCS HCM - Hội SV Trường ĐH KHTN TP.HCM<br />
                Điện thoại: (08) 3835 4008 | Email: doantn@hcmuns.edu.vn | Địa chỉ: 227 Nguyễn Văn
                Cừ, Q5, TP.HCM<br />
            </p>
        </div>
        <!-- footer end -->
    </div>
</body>
</html>
