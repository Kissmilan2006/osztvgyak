import "bootstrap/dist/css/bootstrap.min.css"
import { useEffect, useState } from "react"
import { Link } from "react-router-dom"

function AddCard() {
    const [form, setForm] = useState(
        {
            name: "",
            description: "",
            imgUrl: "",
            colorId: 1
        }
    )

    const HandleChange = (e) => {
        const { name, value } = e.target;
        setForm(prev => ({
            ...prev,
            [name]: name == "ColorId" ? Number(value) : value
        }));
    }
    const HandleSubmit = (e) => {

        e.preventDefault()

        fetch("http://localhost:5076/api/card", {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(form)
        })
            .then(res => {
                if (!res.ok) throw new Error("Http" + res.status)
                alert("Hell yeah")
            })
            .catch(err => console.log(err))

    }



    return (
        <>
            <form onSubmit={HandleSubmit}>
                <div className="form-group">
                    <label htmlFor="CardName">Name</label>
                    <input type="text" placeholder="Enter the Name" name="name" value={form.name} onChange={HandleChange} id="CardName" className="form-control" />
                </div>

                <div className="form-group">
                    <label htmlFor="CardDescription">Description</label>
                    <input type="text" placeholder="Enter the Name" name="description" value={form.description} onChange={HandleChange} id="CardDescription" className="form-control" />
                </div>

                <div className="form-group">
                    <label htmlFor="CardImg">ImgUrl</label>
                    <input type="text" placeholder="Enter the Name" name="imgUrl" value={form.imgUrl} onChange={HandleChange} id="CardImg" className="form-control" />
                </div>


                <div className="form-group">
                    <label htmlFor="CardColor">Name</label>
                    <input type="number" name="colorId" value={form.colorId} onChange={HandleChange} id="CardColor" className="form-control" />
                </div>
                <button type="submit" className="btn btn-primary">Submit</button>
            </form>


        </>
    )
}

export default AddCard
