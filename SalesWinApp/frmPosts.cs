using BusinessObject.Models;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;

namespace SalesWinApp
{
    public partial class frmPosts : Form
    {
        public bool isAdmin { get; set; }

        public int memberId { get; set; }
        BindingSource source;

        IPostRepository postRepository = new PostRepository();

        public frmPosts()
        {
            InitializeComponent();
        }



        private void ClearText()
        {
            txtSearch.Text = string.Empty;
        }
        public void LoadPost(List<PostDTO> list)
        {
            try
            {


                List<PostDTO> posts = new List<PostDTO>();
                if (list.IsNullOrEmpty())
                {
                    posts = postRepository.GetAll();

                }
                else
                {
                    posts = list;
                }

                source = new BindingSource();
                source.DataSource = posts;
                lbTitle.DataBindings.Clear();
                txtContent.DataBindings.Clear();
                lbPostId.DataBindings.Clear();



                lbTitle.DataBindings.Add("Text", source, "PostTitle");
                lbPostId.DataBindings.Add("Text", source, "PostId");
                txtContent.DataBindings.Add("Text", source, "PostContent");


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;

                if (isAdmin == false)
                {
                    if (posts.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = true;

                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
                else
                {
                    if (posts.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;

                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }






        private void frmPosts_Load(object sender, EventArgs e)
        {


            LoadPost(null);
            if (!isAdmin)
            {
                btnDelete.Visible = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnLoad.Visible = false;
            }
            txtContent.ReadOnly = true;
            cboSort.SelectedIndex = 0;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmPostDetail frmPostDetail = new frmPostDetail()
            {
                InsertOrUpdate = true,

            };

            if (frmPostDetail.ShowDialog() == DialogResult.OK)
            {
                LoadPost(null);
                source.Position = source.Count - 1;
            }


        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            cboSort.SelectedIndex = 0;
            LoadPost(null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sortDate = null;

            if (cboSort.Text == "Newest")
            {
                sortDate = "DESC";
            }
            else if (cboSort.Text == "Oldest")
            {
                sortDate = "ASC";
            }
            List<PostDTO> posts = postRepository.SearchByTileAndSortByDate(txtSearch.Text, sortDate);

            LoadPost(posts);

        }

        private int getPostIdBySelectedRow()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    string postIdstr = selectedRow.Cells["PostId"].Value.ToString();

                    int postId = Int32.Parse(postIdstr);
                    return postId;
                }
                else
                {

                    // Không có dòng nào được chọn
                    MessageBox.Show("No rows selected.");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was some error");
                return 0;

            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Do you sure you want to delete this post ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                postRepository.Delete(getPostIdBySelectedRow());
                LoadPost(null);
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmPostDetail frmPostDetail = new frmPostDetail()
            {

                InsertOrUpdate = false,
                PostId = getPostIdBySelectedRow(),


            };

            if (frmPostDetail.ShowDialog() == DialogResult.OK)
            {
                LoadPost(null);
                source.Position = source.Count - 1;
            }

        }
    }

}
