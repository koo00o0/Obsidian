


### SqlDataAdapter
SqlDataAdapter는 데이터베이스와 데이터 사이의 다리 역할을 하는 객체입니다.
SQL Server 데이터베이스에서 데이터를 가져오는 데 사용됩니다.
SqlDataAdapter는 SqlCommand를 기반으로 데이터베이스와 상호 작용하며 데이터를 채웁니다.

------------------------
### DataTable
DataTable은 메모리 상에 테이블 형식의 데이터를 담는 객체입니다.
SqlDataAdapter를 사용하여 데이터베이스로부터 가져온 데이터를 DataTable에 채웁니다.

-----------------------------------
### adapter.Fill(dataTable)
SqlDataAdapter의 Fill 메서드를 호출하여 데이터베이스에서 가져온 데이터를 DataTable에 채웁니다.
Fill 메서드는 SqlDataAdapter가 관리하는 DataTable에 데이터를 로드합니다.
결과적으로, dataTable 객체는 SqlDataAdapter를 사용하여 데이터베이스에서 
가져온 결과를 메모리에 유지하고 있습니다. 이 데이터를 나중에 사용하여 UI에서 표시하거나 다른 작업을 수행할 수 있습니다.

---------------------------------------

예를 들어, 위에서 생성한 dataTable을 ListBox에 데이터를 표시하는 데 사용할 수 있습니다.


```
 SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);


                        // ListBox에 데이터 바인딩
                        listBoxTodo.DataSource = dataTable;
                        listBoxTodo.DisplayMember = "context";
```