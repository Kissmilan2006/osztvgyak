import { useEffect, useState } from "react"

function Cards() {

    const [data, setData] = useState([])
    useEffect(() => {
        fetch("https://localhost:7141/api/card")
            .then(res => res.json())
            .then(json => setData(json))
            .catch(err => console.log(err))
    }, [])
    return (
        <>
            <div className="cotainer container-fluid d-flex text-align-center">
                {
                    data.map(item => {
                        <div key={item.Id}>
                            <img class="card-img-top" src={item.ImgUrl} alt="Card image cap" />
                            <div class="card-body">
                                <h5 class="card-title">{item.Name}</h5>
                                <p class="card-text">{item.Description}</p>

                            </div>
                        </div>
                    })
                }

            </div>
        </>
    )
}

export default Cards
