# Asp.net CRUD


## Create



```C#
pip install foobar
```

## AllRead



```bash
pip install foobar
```
## GetRead



```bash
pip install foobar
```
## Update



```bash
pip install foobar
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
