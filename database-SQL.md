
**1. Create dbStudentRecord database.**

```sql
Create DATABASE dbStudentRecord;
```

**2. Create clients TABLE at dbStudentRecord.**

```sql
CREATE TABLE tbl_studinfo 
(
    id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    stu_roll INT NOT NULL UNIQUE,
    stu_name VARCHAR (30) NOT NULL,
    stu_gender VARCHAR (9) NULL,
    stu_dob VARCHAR (15) NULL,
    stu_email VARCHAR (30) NULL UNIQUE
);
```

**3. Insert some demo data into tbl_studinfo TABLE.**

```sql
INSERT INTO tbl_studinfo (stu_roll, stu_name, stu_gender, stu_dob, stu_email)
VALUES
('101', 'Tamim', 'Male', '19-Jul-1996', 'asmtamim19@gmail.com'),
('102', 'SM Tamim', 'Male', '19-Jul-1997', 'tamim.webdev@gmail.com'),
('103', 'Cristiano Ronaldo', 'Male', '19-Jul-1986', 'cr7@email.com'),
('104', 'Soma', 'Female', '12-11-1998', 'somabubt@gmail.com'),
('105', 'Sharmin', 'Female', '08-Jan-1998', 'somabubt@email.com');
```
