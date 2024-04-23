using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameXH    
{
    public partial class StartGame : Form
    {
        int ktraAmThanh = 1;
        playSound ps = new playSound();
        public StartGame()
        {
            InitializeComponent();
            BtnAmThanh_Click(null, null);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            new fmGame1().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new fmGame2().Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với trò chơi ghép hình!\n\n" +
                "Kiểu chơi 1:\n" +
                "Để chơi, bạn có thể làm như sau:\n" +
                "- Bước 1: Nhấp vào menu 'Mở' để chọn một hình ảnh.\n" +
                "- Bước 2: Nhấp vào menu 'Trộn Ảnh' hoặc nhấn phím F3 để trộn các mảnh ảnh.\n" +
                "- Bước 3: Sử dụng các phím mũi tên hoặc nhấp vào các hướng trên hình ảnh để di chuyển mảnh ảnh.\n" +
                "- Bước 4: Cố gắng sắp xếp các mảnh ảnh để hoàn thành hình ảnh ban đầu.\n" +
                "- Bước 5: Khi hoàn thành, bạn sẽ thấy một thông báo xuất hiện.\n\n" +
                "Kiểu chơi 2:\n" +
                "Để chơi, bạn có thể làm như sau:\n" +
                "- Bước 1: Nhấp vào menu 'File' và chọn 'Open' để chọn một hình ảnh.\n" +
                "- Bước 2: Nhấp vào menu 'Trộn Ảnh' hoặc nhấn phím F3 để trộn các mảnh ảnh.\n" +
                "- Bước 3: Sử dụng chuột để kéo và thả các mảnh ảnh vào vị trí đúng để hoàn thành hình ảnh ban đầu.\n" +
                "- Bước 4: Kiểm tra xem bạn đã hoàn thành hình ảnh chưa. Nếu có, bạn đã thắng!\n" +
                "- Bước 5: Bạn có thể nhấp vào menu 'Chơi Lại' để thử lại hoặc 'Thoát' để thoát khỏi trò chơi.\n\n" +
                "Chúc bạn chơi vui vẻ!",
                "Hướng dẫn chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMove_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightPink;
        }
        private void btnUp_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
        }

        private void BtnAmThanh_Click(object sender, EventArgs e)
        {
            if(ktraAmThanh==1)
            {
                ps.OpenMediaFile("NhacNen.mp3");//ten bai hat.đinh dangcbai hat(bai hat phai di kem voi file exe)
                ps.PlayMediaFile(true);
                btnAmThanh.Text = "Tắt Âm Thanh";
                ktraAmThanh = 0;
            }
            else
            {
                ps.ClosePlayer();
                btnAmThanh.Text = "Bật Âm Thanh";
                ktraAmThanh = 1;
            }
            
        }

        private void StartGame_Load(object sender, EventArgs e)
        {

        }
    }
}
