const express = require('express')
const app = express()

app.get('/', (req, res) => res.send('<h3>Hello World!</h3><p>Mara ba maskara!</p>'))
app.get('/users', (req, res) => res.send('<h3>Users Are Here!</h3><p><ul><li>User 1</li><li>User2</li></ul></p>'))

app.listen(3000, () => console.log('Example app listening on port 3000!'))