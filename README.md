# ASP.net-Core-React
ASP.net core API and React UI form

![capture web app](https://github.com/lpln25/ASP.net-Core-React/blob/master/images/index.png)


---
### 1.download and install packages for [`ASP.net API`](https://github.com/lpln25/ASP.net-Core-React/tree/master/ASP.net%20Core/webAPI)
```
microsoft.entityframeworkcore
microsoft.entityframeworkcore.sqlserver
microsoft.entityframeworkcore.tools
```

### 2.migrate database in command prompt for *ASP.net API*
```
Add-Migration Initialcreate
Update-database
```
---
### 3.create boilerplate React & install dependecy in the same folder *ASP.net API*
1. CMD
```
npx ceate-react-app react-app
```
---if `npx` not define, install [Node.js](https://nodejs.org/en/)

```
cd react-app
code .
```
2. Open new terminal at vscode and install dependecy
```
npm i -s redux react-redux redux-thunk
npm i -s @material-ui/core @material-ui/icons
npm i -s react-toast-notifications
```
3. Replace current folder *src* with this folder [src](https://github.com/lpln25/ASP.net-Core-React/tree/master/React-UI/)
```
npm start
```
---
check your port on *ASP.net API* and *React UI*:
- asp.net API port `55282`
- React port `3000`
----

![capture web app final](https://github.com/lpln25/ASP.net-Core-React/blob/master/images/add%20Item.png)

