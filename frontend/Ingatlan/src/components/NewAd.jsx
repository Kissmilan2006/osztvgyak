import { useState } from "react";

function NewAd() {
    const [form, setForm] = useState({
        kategoria: "",
        leiras: "",
        ar: "",
        tehermentes: false
    });

    // mező változás
    const handleChange = (e) => {
        const { name, value, type, checked } = e.target;

        setForm(prev => ({
            ...prev,
            [name]: type === "checkbox" ? checked : value
        }));
    };

    // küldés API-ra
    const handleSubmit = (e) => {
        e.preventDefault();

        fetch("http://localhost:5158/api/ingatlan", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(form)
        })
            .then(res => {
                if (!res.ok) throw new Error("Hiba mentéskor");
                alert("Sikeres mentés");
            })
            .catch(err => console.error(err));
    };

    return (
        <form onSubmit={handleSubmit} style={{ padding: 20, maxWidth: 400 }}>
            <h2>Hirdetés feladása</h2>

            <div>
                <label>Kategória</label><br />
                <input
                    name="kategoria"
                    value={form.kategoria}
                    onChange={handleChange}
                />
            </div>

            <div>
                <label>Leírás</label><br />
                <input
                    name="leiras"
                    value={form.leiras}
                    onChange={handleChange}
                />
            </div>

            <div>
                <label>Ár</label><br />
                <input
                    name="ar"
                    type="number"
                    value={form.ar}
                    onChange={handleChange}
                />
            </div>

            <div>
                <label>
                    <input
                        type="checkbox"
                        name="tehermentes"
                        checked={form.tehermentes}
                        onChange={handleChange}
                    />
                    Tehermentes
                </label>
            </div>

            <button type="submit">Mentés</button>
        </form>
    );
}

export default NewAd;
