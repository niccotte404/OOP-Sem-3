using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;

namespace PostgresAdapter.Migrations;

[Migration(1, "Init")]
public class Init : SqlMigration
{
    protected override string GetUpSql(IServiceProvider serviceProvider) =>
     """
    create type UserRole as enum
    (
        'Admin',
        'User'
    );

    create table Users
    (
        UserId bigint primary key generated always as identity ,
        UserName text unique ,
        Pincode int not null ,
        Balance decimal ,
        Role UserRole not null
    );

    create table Admins
    (
        AdminId bigint primary key generated always as identity ,
        AdminName text unique ,
        Password text not null ,
        Role UserRole not null
    );

    create table History
    (
        RowId bigint primary key generated always as identity ,
        UserId bigint not null references Users(UserId),
        LogMessage text
    );
    """;

    protected override string GetDownSql(IServiceProvider serviceProvider) =>
    """
    drop table Users;
    drop table Admins;
    drop table History;
    
    drop type UserRole;
    """;
}