



## DB로 쿼리 문 전달 문법 양식 (예 : 로그인 폼)


------------------------------------
#### 작성자 (정용재)
```
  private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool login = false;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string login_id = userid.Text;
                string login_password = userpw.Text;

                string sql = "SELECT * FROM user_yj WHERE userid = @userid AND userpw = @userpwd";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@userid", login_id);
                    cmd.Parameters.AddWithValue("@userpwd", login_password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            login = true;
                        }
                    }
                }
            }
            if (login)
            {
                // 여기서는 LoginID와 textBoxID를 찾지 못할 것이다.
                // 이 부분은 프로그램의 전체 코드가 필요하므로 정확한 수정을 위해서는 모든 코드를 확인해야 합니다.
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("아이디/암호를 확인해 주세요.");
            }
        }

```
