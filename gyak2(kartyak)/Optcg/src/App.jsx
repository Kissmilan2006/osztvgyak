import { useState } from 'react'
import Cards from './components/Cards'
import './App.css'
import Home from './components/Home'
import { BrowserRouter, Route, Routes } from 'react-router-dom'

function App() {
  const [count, setCount] = useState(0)

  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='/cards' element={<Cards />} />
      </Routes>
    </BrowserRouter>
  )
}

export default App
