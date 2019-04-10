using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ScinesDataBase
{
    private const String Tag = "Riz: LocationDb:\t";

    private const String TABLE_NAME = "Scines";
    private const String KEY_NAME = "NAME";
    private const String PRICE = "PRICE";
    private const String IS_BOUGHT = "BOUGHT";
    private String[] COLUMNS = new String[] { KEY_NAME, PRICE, IS_BOUGHT };


    private const string database_name = "my_db";
    public string db_connection_string;
    public IDbConnection db_connection;

    public ScinesDataBase()
    {
        db_connection_string = "URI=file:" + Application.persistentDataPath + "/" + database_name;
        db_connection = new SqliteConnection(db_connection_string);
        db_connection.Open();
    }

    public void createTable()
    {
        IDbCommand dbcmd = getDbCommand();
        dbcmd.CommandText = "CREATE TABLE IF NOT EXISTS " + TABLE_NAME + " ( " +
            KEY_NAME + " TEXT PRIMARY KEY, " +
            PRICE + " INTEGER, " +
            IS_BOUGHT + " INTEGER)";
        dbcmd.ExecuteNonQuery();
    }

    public IDbCommand getDbCommand()
    {
        return db_connection.CreateCommand();
    }

    public void close()
    {
        db_connection.Close();
    }

    public void insertData(ScineEntity entity)
    {
        System.Data.IDbCommand dbcmd = getDbCommand();
        dbcmd.CommandText =
            "INSERT INTO " + TABLE_NAME
            + " ( "
            + KEY_NAME + ", "
            + PRICE + ", "
            + IS_BOUGHT + " ) "

            + "VALUES ( '"
            + entity.name + "', "
            + entity.price + ", "
            + entity.isBought + " )";
        dbcmd.ExecuteNonQuery();
    }

    public void updateData(string inName, int isBought)
    {
        System.Data.IDbCommand dbcmd = getDbCommand();
        dbcmd.CommandText =
            "UPDATE  INTO " + TABLE_NAME
            + " set "
            + IS_BOUGHT + " = "+isBought
            + " where "
            + KEY_NAME + " = "
            + inName;
        dbcmd.ExecuteNonQuery();
    }

    public IDataReader getAllData()
    {
        IDbCommand dbcmd = db_connection.CreateCommand();
        dbcmd.CommandText =
            "SELECT * FROM " + TABLE_NAME;
        IDataReader reader = dbcmd.ExecuteReader();
        return reader;
    }

    public List<ScineEntity> getScines()
    {
        List<ScineEntity> list = new List<ScineEntity>();
        System.Data.IDataReader reader = getAllData();
        int fieldCount = reader.FieldCount;
        while (reader.Read())
        {
            ScineEntity entity = new ScineEntity(reader[0].ToString(),
                                    int.Parse(reader[1].ToString()),
                                    int.Parse(reader[2].ToString()));
                                    
            list.Add(entity);
        }
        return list;
    }

    public struct ScineEntity
    {
        public ScineEntity(string inName, int price, int isBought)
        {
            this.name = inName;
            this.price = price;
            this.isBought = isBought;
        }
        public string name;
        public int price;
        public int isBought;
    }
}