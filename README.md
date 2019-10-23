# Asp.net CRUD


## Create



```C#
 //TestModel 값을 받아와서 삽입
        public TestModel PostTest(TestModel model)
        {
            string query = "INSERT INTO [dbo].[Tabletest] ([title],[contents],[date]) VALUES (@title,@contents,@dateinfo)";
            var connection = Dbinfo.MsConnection();
            //searchModel 값의 앞의 title (model.title 말고)은 받아오는 html.cs에서 name값과 같아야함
            var searchModel = new { title = model.title, contents = model.contents,  dateinfo = model.date };
            //Select문과 다르게 query옆에 넣어줘야할 데이터 값을 넣어줘야함
            return connection.Query<TestModel>(query, searchModel).FirstOrDefault();
        }
```

## AllRead



```C#
//모든 리스트 다 출력
        public List<TestModel> GetAllTest()
        {
            
            string query = "SELECT * FROM [dbo].[Tabletest] ORDER BY no DESC";
            var connection = Dbinfo.MsConnection();
          
            
            return connection.Query<TestModel>(query).ToList();
            //ToLIst()를 사용하면 List형식으로 반환
        }
```
## GetRead



```C#
  //no값을 받아와서 TestModel 값 하나만 출력
        public TestModel GetSelect(int no)
        {
            string query = "SELECT * FROM [dbo].[Tabletest] WHERE no = @no";
            var connection = Dbinfo.MsConnection();
            var searchModel = new { no = no };

            return connection.Query<TestModel>(query, searchModel).FirstOrDefault();
            //FirstOrDefault는 ToList와 다르게 하나의 값만 출력
        }
```
## Update



```C#
 //TestModel 수정
        public TestModel PutTest(TestModel model)
        {
            string query = "UPDATE [dbo].[Tabletest] SET [title] = @title, [contents] = @contents, [date] = @datainfo WHERE no = @no";
            var connection = Dbinfo.MsConnection();
            var searchModel = new { title = model.title, contents = model.contents, datainfo = model.date, no = model.no };

            return connection.Query<TestModel>(query, searchModel).FirstOrDefault();
        }
```
## Delete

```C#
 public TestModel DelTest(int no)
        {
            string query = "DELETE FROM [dbo].[Tabletest] WHERE no=@no";
            var connection = Dbinfo.MsConnection();
            var searchModel = new { no = no };

            return connection.Query<TestModel>(query, searchModel).FirstOrDefault();
        }
```
