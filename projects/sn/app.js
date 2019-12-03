const express = require('express');
const app = express();
const bodyParser = require('body-parser')
app.use( bodyParser.json() );
app.use(bodyParser.urlencoded({ extended: true })); 

const port = 8080;

app.get('/', function (req, res) {
	res.send(`
		Hello World!<br>
		${req.query.test}

		`);
});

// Для получения переменных из HTML формы
// let login = req.body.login,


app.listen(port, () => console.log(`Example app listening on port ${port}!`));
