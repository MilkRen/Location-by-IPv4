# Location-by-IPv4
<p align="center">
<img src="https://github.com/MilkRen/Location-by-IPv4/blob/master/Ip/Logo.png?raw=true"></p>
Hello, in this application I made finding the location by IPv4 using the API - ipwho.is

 With this API, you can get the location of the city, village, find out the provider (you can look at the official API website to get acquainted with the functionality and edit code it for yourself).

#

<p align="center">
<img src="https://raw.githubusercontent.com/MilkRen/Location-by-IPv4/master/img_github/Screenshot1.png" width=250 height=380></p>

<p align="center">
<img src="https://raw.githubusercontent.com/MilkRen/Location-by-IPv4/master/img_github/Screenshot2.png" width=250 height=380></p>


Regex is used for the main cases, and the rest is cosmetic. Comments have been added to some points to make it clear. 
Use it, learn it! Criticism is welcome!)

```text
 str = wc.DownloadString($"http://ipwho.is/{textBoxInputIP.Text}"); // API
            
match = Regex.Match(str, "\"country\":\"(.*?)\",(.*?)\"region\":\"(.*?)\",(.*?)\"city\":\"(.*?)\",\"latitude\":(.*?),\"longitude\":(.*?),(.*?)\"domain\":\"(.*?)\"},\"(.*?)\","); //(.*?) - I find missing elements in the specified deopazon

```

# Framework
<p align="center">
<img src="https://raw.githubusercontent.com/MilkRen/Location-by-IPv4/master/img_github/Screenshot3.png" width=500 height=150></p>



## Social: [![](https://img.shields.io/badge/YouTube-090909??style=for-the-badge&logo=youtube&logoColor=FF0000)](https://www.youtube.com/) [![](https://img.shields.io/badge/telegram-090909??style=for-the-badge&logo=telegram&)](https://t.me/MilkRen)
