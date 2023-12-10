

const express = require('express');
const app = express();
const PORT = 3000;

// Ruta principal
app.get('/', (req, res) => {
  res.send('¡Hola, esta es la ruta principal!');
});

// Ruta secundaria
app.get('/ruta-secundaria', (req, res) => {
  res.send('¡Hola, esta es la ruta secundaria!');
});

// Iniciar el servidor
app.listen(PORT, () => {
  console.log(`Servidor escuchando en http://localhost:${PORT}`);
});
