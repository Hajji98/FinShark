using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.StockDto;
using api.Models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this StockModel StockModelModel) {
            return new  StockDto {
                ID = StockModelModel.ID,
                Symbol = StockModelModel.Symbol,
                CompanyName = StockModelModel.CompanyName,
                Purchase = StockModelModel.Purchase,
                LastDiv = StockModelModel.LastDiv,
                Industry = StockModelModel.Industry,
                Marketcap = StockModelModel.Marketcap,

            };
        }

        public static StockModel ToStockFromCreatDto(this CreateStockRequestDto StockDto)
        {
            return new StockModel {
                Symbol = StockDto.Symbol,
                CompanyName = StockDto.CompanyName,
                Purchase = StockDto.Purchase,
                LastDiv = StockDto.LastDiv,
                Industry = StockDto.Industry,
                Marketcap = StockDto.Marketcap,
              

            };
        }
    }
}