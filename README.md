# screenscrape
Powershell module to make screen scraping easier. Leveraging htmlagiltypack and fizzler. Basically needed a quick way to screen scrape using powershell. Needed querySelectorAll, ability to lookup parent elements.. 


## Example 1
```powershell
$page = New-HtmlDocument -FromUri "http://www.contoso.com"
$firstLink = $page | Get-Element -Selector "a.someclass"
$allLinks = $page | Get-Elements -Selector "li>a"
$parent = $firstLink | Get-Parent -Selector "div.link"
```
## Example 2
If you need to provide authentication or just want to test using a string value instead of loading directly. Also nice when you may want to search for just text as well without using compound selectors.
```powershell
$WebResponse = Invoke-WebRequest "http://www.contoso.com"
$page = New-HtmlDocument -FromString $WebResponse.Content
$firstLink = $page | Get-Element -Selector "a.someclass"
$allLinks = $page | Get-Elements -Selector "li>a"
$parent = $firstLink | Get-Parent -Selector "div.link"
```

