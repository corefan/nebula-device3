/* Original version Copyright (C) Scott Bilas, 2000.
* All rights reserved worldwide.
*
* This software is provided "as is" without express or implied
* warranties. You may freely copy and compile this source into
* applications you distribute provided that the copyright text
* below is included in the resulting source code, for example:
* "Portions Copyright (C) Scott Bilas, 2000"
*/
#ifndef _MATHML_SINGLETON_H__
#define _MATHML_SINGLETON_H__

#include "MathMLSolverPrerequisites.h"

// Turn off warnings generated by this singleton implementation
#   pragma warning (disable : 4311)
#   pragma warning (disable : 4312)

namespace MathML
{
    /** Template class for creating single-instance global classes.
    */

    template <typename T>

    class Singleton
    {

    protected:

        static T* ms_Singleton;

    public:
        Singleton( void )
        {
            assert( !ms_Singleton );
#if defined( _MSC_VER ) && _MSC_VER < 1200

            int offset = ( int ) ( T* ) 1 - ( int ) ( Singleton <T>* ) ( T* ) 1;
            ms_Singleton = ( T* ) ( ( int ) this + offset );
#else

            ms_Singleton = static_cast< T* >( this );
#endif

        }

        ~Singleton( void )
        {
            assert( ms_Singleton );
            ms_Singleton = 0;
        }

        static T& getSingleton( void )
        {
            assert( ms_Singleton );
            return ( *ms_Singleton );
        }

        static T* getSingletonPtr( void )
        {
            return ms_Singleton;
        }
    };
}

#endif
