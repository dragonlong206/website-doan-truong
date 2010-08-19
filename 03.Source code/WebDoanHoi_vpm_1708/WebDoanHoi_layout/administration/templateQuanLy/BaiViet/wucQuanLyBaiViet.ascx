﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQuanLyBaiViet.ascx.cs"
    Inherits="WebDoanHoi_layout.administration.templateQuanLy.BaiViet.wucQuanLyBaiViet" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<div id="body" class="clearfix">
    <div class="wrapper">
        <div class="col">
            <table>
                <tr>
                    <td colspan="2" align="center">
                        <h2>
                            <asp:LinkButton ID="btnCapNhat" runat="server" OnClick="btnCapNhat_Click">Cập nhật</asp:LinkButton>
                            &nbsp;-&nbsp;
                            <asp:LinkButton runat="server" ID="btnThem" CssClass="new-study-model" OnClick="btnThem_Click"
                                Text="Thêm"></asp:LinkButton>
                            &nbsp;-&nbsp;
                            <asp:LinkButton runat="server" ID="btnXoa" CssClass="new-study-model" OnClick="btnXoa_Click"
                                Text="Xóa"></asp:LinkButton>
                        </h2>
        <asp:Literal runat="server" ID="lbThongBao" Visible="false"></asp:Literal>
                    </td>
                </tr>
            </table>
            <h1>
                Thông tin Bài Viết</h1>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Panel runat="server" ID="UpdatePanel">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <table width="70%">
                            <tr>
                                <td>
                                    <label>
                                        Tiêu đề</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txttieude" runat="server" CssClass="field-input" Width="200px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txttieude"
                                        ErrorMessage="Mời bạn nhập Tiêu Đề"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Chuyên mục
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlChuyenMuc" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlChuyenMuc_SelectedIndexChanged"
                                        Width="200px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Loại bài viết
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlLoaiBaiViet" runat="server" Width="200px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <lable>
                                                Ảnh đại diện</lable>
                                </td>
                                <td>
                                    <asp:FileUpload ID="fulImage" runat="server" />
                                     <asp:Image ID="imgAnhDaiDien" runat="server" Width="100px" Height="100px"/>
                                </td>                               
                            </tr>
                            <tr>
                                <td>
                                    Tóm tắt
                                </td>
                                <td>
                                    <asp:TextBox ID="txtTomTat" runat="server" Height="93px" TextMode="MultiLine" Width="441px"></asp:TextBox>
                                </td>
                                <td>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <tabe>
                    <caption>
                        <caption>
                            <label>
                            Nội dung</label></caption>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <FCKeditorV2:FCKeditor ID="txtnoidung" runat="server" Height="500px">
                                </FCKeditorV2:FCKeditor>
                            </td>
                        </tr>
                    </caption>
                </table>
                
                <div class="post-content">
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
        <asp:Panel ID="PanelMessage" runat="server">
             <div class="message" style="width:90%;display:table; background-image:url('./images/icon-error.gif'); background-color:#FFFFCC;background-position:10px 50%;background-repeat:no-repeat; border:0.1em solid #CC0000;margin:0.5em 0;padding:10px 10px 10px 36px;">
                   Chưa có dữ liệu
            </div>
            </asp:Panel >
            <asp:Panel ID="PanelDanhSach" runat="Server">
                        <asp:GridView ID="GridViewTapTin" runat="server" 
                AutoGenerateColumns="False" 
                CssClass="tablestyle" DataKeyNames="mataptin"  >             
                <Columns>
                    <asp:BoundField HeaderText="STT" />
                    
                    <asp:HyperLinkField DataTextField="tentaptin" HeaderText="Tập tin" 
                        NavigateUrl="~/Default.aspx" DataNavigateUrlFields="duongdan" 
                        ItemStyle-Width="30%" SortExpression="mataptin" >
                        <ItemStyle Width="30%" />
                     </asp:HyperLinkField>
                     
                    <asp:BoundField DataField="duongdan" HeaderText="Đường dẫn"/>
                </Columns>
    </asp:GridView>       
            </asp:Panel>
         <asp:Panel ID="PanelBtnUpload" runat="server" Style="margin-top: 10px;">
            <asp:Button ID="btnUploadFiles" runat="server" Text="Upload Files" 
                onclick="btnUploadFiles_Click" />
                </asp:Panel>
                <asp:Panel ID="PanelUploadTapTinBaiViet" runat="server" Visible="false">
            <asp:FileUpload ID="FileUploadTapTin" runat="server" />
            <asp:Label ID="LabelUploadStatus" runat="server"></asp:Label>
            <asp:Button ID="btnUpload" runat="server" Text="Upload" 
                onclick="btnUpload_Click"/>
    </asp:Panel>
    <asp:Panel ID="PanelDownload" runat="server">
                 </asp:Panel>
                 </ContentTemplate>
            <triggers>
                <asp:PostBackTrigger ControlID="btnUpLoad" />
                <asp:AsyncPostBackTrigger ControlID="GridViewTapTin" 
                    EventName="SelectedIndexChanged" />
            </triggers>
           </asp:UpdatePanel>
           
        </div>
        <br />
            </asp:Panel>
    </div>
</div>
</div> 