# ASP.net-Core-React
ASP.net core API and React UI

<img src="https://github.com/lpln25/ASP.net-Core-React/blob/master/images/index.png" width="1024" height="310" />

---
### 1.download and install packages for [`ASP.net API`](https://github.com/lpln25/ASP.net-Core-React/tree/master/ASP.net%20Core/webAPI)
```
microsoft.entityframeworkcore
microsoft.entityframeworkcore.sqlserver
microsoft.entityframeworkcore.tools
```

### 2.migrate database in console for `ASP.net API`
```
Add-Migration Initialcreate
Update-database
```
---
### 3.create React & install packages in the same folder `ASP.net API`
1. CMD `npx ceate-react-app react-app`
---if `npx` not define, install [Node.js](https://nodejs.org/en/)
2. CMD `cd react-app`\
3. CMD `code .`
4. Terminal `npm start`
5. Terminal VSCode ``npm i -s redux react-redux redux-thunk``
6. Terminal VSCode ``npm i -s @material-ui/core @material-ui/icons``
7. Terminal VSCode ``npm i -s react-toast-notifications``

---
### 4.replace folder `src` in your `react-app` with this folder [src](https://github.com/lpln25/ASP.net-Core-React/tree/master/React-UI/)

---
### 5.check your port on `ASP.net API` and `React UI`
asp.net api port `55282`
react port `3000`
