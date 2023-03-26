using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Avalonia.Controls;
using System.Security.Cryptography;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AniLib.classes;

[SuppressMessage("Interoperability", "CA1416:Plattformkompatibilität überprüfen")]
public class Account{
    
    public string username { get; set; }
    public string password { get; set; }
    public Guid guid { get; set; }
    public bool isLoggedIn { get; set; }
    
    // other properties, might implement later
    private DateTime creationDate;
    private DateTime lastLogin;
    private string email;
    private Image profilePicture;
    private string bio;
    private string location;

    public Account(string username, string password){
        this.username = username;
        this.password = password;
        this.guid = Guid.NewGuid();
    }
    
    public static string Encrypt(string plainText)
    {
        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
        byte[] encryptedBytes = ProtectedData.Protect(plainBytes, null, DataProtectionScope.CurrentUser);
        return Convert.ToBase64String(encryptedBytes);
    }

    public static string Decrypt(string cipherText)
    {
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        byte[] decryptedBytes = ProtectedData.Unprotect(cipherBytes, null, DataProtectionScope.CurrentUser);
        return Encoding.UTF8.GetString(decryptedBytes);
    }

    public void register(){
        // encrypt password and save to database
        string encryptedPassword = Encrypt(password);
        // save to database
        var account = new BsonDocument
        {
            { "username", username },
            { "password", encryptedPassword },
            { "guid", guid.ToString() }
        };
    }
    public void login(){ }
    public void logout(){ }
    public void update(){ }
    public void delete(){ }
    public void changePassword(){ }
}