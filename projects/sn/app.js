const express = require('express');
const session = require('express-session')
const app = express();
const bodyParser = require('body-parser')
app.use( bodyParser.json() );
app.use(bodyParser.urlencoded({ extended: true })); 
app.use(session({
    secret: '34SDgsdgspxxxxxxxdfsG', // just a long random string
    resave: false,
    saveUninitialized: true
}));

const port = 8080;

app.get('/', function (req, res) {
	console.log(req.session.id)

	res.send(`
		Hello World!<br>
		${req.query.test}

		`);
});

// Для получения переменных из HTML формы
// let login = req.body.login,


app.listen(port, () => console.log(`Example app listening on port ${port}!`));
