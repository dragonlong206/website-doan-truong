<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Album.aspx.cs" Inherits="WebDoanHoi_layout.Album" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Galleria Classic Theme Demo 02</title>

    <script src="js/jquery-1.4.2.js"></script>

    <script src="js/galleria.js"></script>

    <style>
        html, body
        {
            background: #111;
        }
        #galleria
        {
            width: 900px;
            margin: 20px auto;
        }
        a
        {
            color: #aaa;
        }
    </style>
</head>
<body>
    <div id="galleria">
        <div>
            <a href="../Hinh_/IMG_1289.JPG">
                <img src="../Hinh_/IMG_1289.JPG">
            </a><strong>Strawberries</strong> <span>Lorem ipsum dolor sit amet, <a href="#">consectetur</a>
                adipiscing <em>elit</em>. Etiam quam velit, aliquet nec sodales vel, porttitor id
                justo. </span>
        </div>
        <div>
            <a href="../Hinh_/IMG_1341.JPG">
                <img src="../Hinh_/IMG_1341.JPG">
            </a><strong>Strawberries</strong> <span>Lorem ipsum dolor sit amet, <a href="#">consectetur</a>
                adipiscing <em>elit</em>. Etiam quam velit, aliquet nec sodales vel, porttitor id
                justo. </span>
        </div>
        <div>
            <a href="../Hinh_/IMG_1356.JPG">
                <img src="../Hinh_/IMG_1356.JPG">
            </a><strong>Strawberries</strong> <span>Lorem ipsum dolor sit amet, <a href="#">consectetur</a>
                adipiscing <em>elit</em>. Etiam quam velit, aliquet nec sodales vel, porttitor id
                justo. </span>
        </div>
        <div>
            <a href="../Hinh_/IMG_1289.JPG">
                <img src="../Hinh_/IMG_1289.JPG">
            </a><strong>Strawberries</strong> <span>Lorem ipsum dolor sit amet, <a href="#">consectetur</a>
                adipiscing <em>elit</em>. Etiam quam velit, aliquet nec sodales vel, porttitor id
                justo. </span>
        </div>
    </div>

    <script>

        // Load theme
        Galleria.loadTheme('js/themes/classic/galleria.classic.js');

        // run galleria and add some options
        $('#galleria').galleria({
            image_crop: true,
            data_config: function(img) {
                // will extract and return image captions from the source:
                return {
                    title: $(img).parent().next('strong').html(),
                    description: $(img).parent().next('strong').next().html()
                };
            }
        });
    </script>

</body>
</html>
