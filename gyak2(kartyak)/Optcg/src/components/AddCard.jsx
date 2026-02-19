import { useEffect, useState } from "react";
import { Link } from "react-router-dom";
function AddCard() {
  const [form,setForm] = useState({
    name:"",
    description:"",
    imgUrl:"",
    colorId:1
  });

  const HandleChange = (e) =>{
    const {name, value}= e.target;

    setForm(prev =>({
        ...prev,
        [name] : name == "colorId" ? Number(value) : value
    }));
  };

  const HandleSubmit = (e) =>{
    e.preventDefault()

    fetch("https://localhost:7141/api/card",{
        method: "POST",
        header: {"Content-Type":"application/json"},
        body: JSON.stringify(form)
    })
    .then(res=>{
        if(!res.ok) throw new Error("Http" + res.status)
        alert("sikeres mentes")
    })
    .catch(err => console.log(err))
  }
    return (
        <>
            <Link to="/" className="btn btn-primary">
                Vissza
            </Link>

            <div className="container container-fluid">
    <form onSubmit={handleSubmit}>
  <div className="form-group">
    <label for="CardName">Name</label>
    <input type="text" value={form.name} onChange={HandleChange} className="form-control" id="CardName"  placeholder="Enter Name"/>
  </div>
  <div className="form-group">
    <label for="CardDescription">Description</label>
    <input type="text" value={form.description} onChange={HandleChange} className="form-control" id="CardDescription" placeholder="Description"/>
  </div>
   <div className="form-group">
    <label for="CardImgUrl">Image Url</label>
    <input type="text" value={form.imgUrl} onChange={HandleChange} className="form-control" id="CardImgUrl" placeholder="Image Url"/>
  </div>
   <div className="form-group">
    <label for="CardColor">Image Url</label>
    <input type="number" value={form.colorId} onChange={HandleChange} className="form-control" id="CardColor" placeholder="Colro"/>
  </div>

  <button type="submit" className="btn btn-primary">Submit</button>
</form>
            </div>
            
        </>
    )
}

export default AddCard
