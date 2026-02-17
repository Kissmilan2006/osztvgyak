import { BrowserRouter, Routes, Route } from "react-router-dom";
import Offers from "./components/Offers";
import Hero from "./components/hero";
import NewAd from "./components/NewAd";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Hero />} />
        <Route path="/offers" element={<Offers />} />
        <Route path="/newad" element={<NewAd />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
