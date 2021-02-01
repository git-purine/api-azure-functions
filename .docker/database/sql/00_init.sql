IF NOT EXISTS(SELECT 1 FROM sys.server_principals WHERE name='func_cs_user')
    CREATE LOGIN func_cs_user WITH PASSWORD = 'QdApg_VEyCk6';
ALTER SERVER ROLE dbcreator ADD MEMBER func_cs_user;
GO
