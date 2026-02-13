const express = require('express');
const cors = require('cors');
const swaggerUi = require('swagger-ui-express');

const app = express();
app.use(cors());
app.use(express.json());

// --- ADATOK (A PDF mintája alapján [cite: 36, 53]) ---
const mufajok = [
    { id: 1, megnevezes: "Sci-fi" },
    { id: 2, megnevezes: "Krimi" }
];

let konyvek = [
    { id: 1, mufajId: 1, mufajNev: "Sci-fi", cim: "Alapítvány", szerzo: "Isaac Asimov", kiadasEve: 1951 },
    { id: 2, mufajId: 2, mufajNev: "Krimi", cim: "Tíz kicsi néger", szerzo: "Agatha Christie", kiadasEve: 1939 },
    { id: 3, mufajId: 1, mufajNev: "Sci-fi", cim: "Dűne", szerzo: "Frank Herbert", kiadasEve: 1965 }
];

// --- SWAGGER DEFINÍCIÓ [cite: 13, 14, 26] ---
const swaggerDocument = {
    openapi: '3.0.0',
    info: { title: 'KonyvWebAPI', version: '1.0.0' },
    paths: {
        '/api/mufajok': {
            get: { summary: 'Műfajok lekérése', responses: { '200': { description: 'Sikeres' } } }
        },
        '/api/konyvek': {
            get: { summary: 'Összes könyv lekérése', responses: { '200': { description: 'Sikeres' } } }
        },
        '/api/ujkonyv': {
            post: { 
                summary: 'Új könyv rögzítése', 
                requestBody: { content: { 'application/json': { schema: { type: 'object' } } } },
                responses: { '201': { description: 'Létrehozva' } } 
            }
        }
    }
};

// --- VÉGPONTOK (A PDF logikája szerint [cite: 34, 51, 79]) ---
app.use('/docs', swaggerUi.serve, swaggerUi.setup(swaggerDocument, {
    customCss: '.swagger-ui .topbar { display: none }',
    swaggerOptions: {
        supportedSubmitMethods: ['get', 'post', 'put', 'delete']
    }
}));

app.get('/api/mufajok', (req, res) => res.json(mufajok));
app.get('/api/konyvek', (req, res) => res.json(konyvek));
app.post('/api/ujkonyv', (req, res) => {
    const ujKonyv = { id: konyvek.length + 1, ...req.body };
    konyvek.push(ujKonyv);
    res.status(201).json(ujKonyv);
});

// --- INDÍTÁS [cite: 9, 10, 11] ---
const PORT = 5000;
app.listen(PORT, () => {
    console.log(`Info: Microsoft.Hosting.Lifetime[0]`);
    console.log(`Now listening on: http://localhost:${PORT}`);
    console.log(`Application started. Press Ctrl+C to shut down.`);
});