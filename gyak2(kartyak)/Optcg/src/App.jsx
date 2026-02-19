import { useState } from 'react'
import Cards from './components/Cards'
import './App.css'
import Home from './components/Home'
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import AddCard from './components/AddCard'

function App() {

  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='/cards' element={<Cards />} />
        <Route path='/addcard' element={<AddCard />} />
      </Routes>
    </BrowserRouter>
  )
}

export default App
